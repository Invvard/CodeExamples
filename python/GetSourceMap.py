import urllib.request
import re

sc = 'https://configure.ergodox-ez.com/layouts/EOEb/latest/0'


def get_pagecontent(url):
    response = urllib.request.urlopen(url)
    data = response.read()
    page_content = data.decode('utf-8')
    return page_content


def get_filenames(text):
    file_list = []
    pattern_source_maps = r'"static/js/"\+\(\{\}\[l\]\|\|l\)\+"\."\+\{(?P<sourcemaps>(?:\d:"[a-f0-9]+",?)*?)}'
    pattern_files = r'(?P<index>\d):"(?P<filename>[a-f0-9]+)"'

    source_maps = re.search(pattern_source_maps, text)
    if source_maps:
        files = re.finditer(pattern_files, source_maps.group('sourcemaps'))
        for file in files:
            file_list.append(file.group('filename'))

    return file_list


content = get_pagecontent('https://configure.ergodox-ez.com/layouts/EOEb/latest/0')
fileList = get_filenames(content)

print(fileList)
