import urllib.request
import re
import sourcemap

configuratorUrl = 'https://configure.ergodox-ez.com/ergodox-ez/layouts/default/latest/0'


def get_page_content(url):
    response = urllib.request.urlopen(url)
    data = response.read()
    page_content = data.decode('utf-8')
    return page_content


def get_filenames(text):
    file_list = []
    pattern_source_maps = r'"static/js/"\+\(\{\}\[l\]\|\|l\)\+"\."\+\{(?P<sourcemaps>(?:\d:"[a-f0-9]+",?)*?)}'
    pattern_chunk_name = r'<script src="\/static\/js\/(?P<chunk>.*?)\.chunk\.js"><\/script>'
    pattern_files = r'(?P<index>\d):"(?P<filename>[a-f0-9]+)"'

    chunks = re.finditer(pattern_chunk_name, text)
    if chunks:
        for chunk in chunks:
            file_list.append(chunk.group("chunk"))

    source_maps = re.search(pattern_source_maps, text)
    if source_maps:
        files = re.finditer(pattern_files, source_maps.group('sourcemaps'))
        for file in files:
            file_list.append(f'{file.group("index")}.{file.group("filename")}')

    return file_list


def get_files():
    for chunkFileId in chunkFileIds:
        chunk_url = f'https://configure.ergodox-ez.com/static/js/{chunkFileId}.chunk.js.map'
        source_map = sourcemap.load(urllib.request.urlopen(chunk_url))

        if next((x for x in source_map.tokens if 'keyDefinitions' in x.src), None) is not None:
            print(source_map.tokens)
            filter_iter = filter(lambda x: 'keyDefinitions' in x.src, source_map.tokens)
            data = next(filter_iter).src
            print(data)
            break



content = get_page_content(configuratorUrl)
chunkFileIds = get_filenames(content)
get_files()

print(chunkFileIds)
