import data

def is_hulk(hero):
    return hero['name'] == 'Hulk'

hulk = next((hero for hero in data.heroes if is_hulk(hero)), None)

print(hulk)
#$ python3 find.py
#expected output
#{ name: 'Hulk', strength: 90000 }