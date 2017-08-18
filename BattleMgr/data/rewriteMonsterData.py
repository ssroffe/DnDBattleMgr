import json

with open("monsterData.json","r") as f:
    data = json.load(f)

tmpData = data
for key in data:
    try:
        tmp = data[key]['legendary_actions']
        #tmp = data[key]['special_abilities']
    except KeyError as e:
        tmpData[key][e.args[0]] = []
        
for key in tmpData:
    try:
        #tmp = data[key]['legendary_actions']
        tmp = data[key]['special_abilities']
    except KeyError as e:
        tmpData[key][e.args[0]] = []

for key in tmpData:
    try:
        #tmp = data[key]['legendary_actions']
        tmp = data[key]['actions']
    except KeyError as e:
        tmpData[key][e.args[0]] = []

for key in tmpData:
    try:
        #tmp = data[key]['legendary_actions']
        tmp = data[key]['notes']
    except KeyError as e:
        tmpData[key][e.args[0]] = ""

newData = [ { "name": tmpData[key]['name'], "size":tmpData[key]['size'], "type":tmpData[key]['type'], "subtype":tmpData[key]['subtype'], "alignment":tmpData[key]['alignment'], "armor_class":tmpData[key]['armor_class'], "hit_points": tmpData[key]['hit_points'], "speed":tmpData[key]['speed'], "strength":tmpData[key]['strength'], "dexterity":tmpData[key]['dexterity'], "constitution":tmpData[key]['constitution'], "intelligence":tmpData[key]['intelligence'], "wisdom":tmpData[key]['wisdom'],"charisma":tmpData[key]['charisma'], "damage_vulnerabilities":tmpData[key]['damage_vulnerabilities'], "damage_resistances":tmpData[key]['damage_resistances'], "condition_immunities":tmpData[key]['condition_immunities'], "senses":tmpData[key]['senses'], "languages":tmpData[key]['languages'], "challenge_rating":tmpData[key]['challenge_rating'], "notes":tmpData[key]['notes'], "special_abilities":tmpData[key]['special_abilities'],"actions":tmpData[key]['actions'], "legendary_actions":tmpData[key]['legendary_actions'] } for key in tmpData]
"""
newData = [ { "name": tmpData[key]['name'], "desc":tmpData[key]['desc'], "range": tmpData[key]['range'], 'components': tmpData[key]['components'],
          "ritual": tmpData[key]['ritual'], "duration": tmpData[key]['duration'], "concentration": tmpData[key]['concentration'], "casting_time": tmpData[key]['casting_time'],
          "level": tmpData[key]['level'], "school": tmpData[key]['school']['name'], "clss": [tmpData[key]['classes'][i]['name'] for i in range(len(tmpData[key]['classes']))], "subclss": [tmpData[key]['subclasses'][i]['name'] for i in range(len(tmpData[key]['subclasses']))]
          } for key in tmpData] 
"""
with open("monsters.json","w") as outfile:
    json.dump(newData,outfile)
