import urllib.request

url = 'https://configure.ergodox-ez.com/layouts/EOEb/latest/0'
response = urllib.request.urlopen(url)
data = response.read()
text = data.decode('utf-8')

print(text)
