import pymysql
import urllib.request as urllib
from bs4 import BeautifulSoup

# Database connection
db = pymysql.connect("localhost", "root", "", "test")
cursor = db.cursor()

r = urllib.urlopen('https://www.moneycontrol.com/').read()
soup = BeautifulSoup(r, 'lxml')

nifty = soup.findAll("table", {"class": "rhsglTbl"})[
    7].findAll('tr')
sensex = soup.findAll("table", {"class": "rhsglTbl"})[
    8].findAll('tr')

print("Nifty Top Losers")

for i in range(1, 6):
    a = nifty[i].findAll('td')[0].text
    b = nifty[i].findAll('td')[2].text

    # Database Insertion
    data = cursor.execute("""INSERT INTO MoneyControl(COMPANY,
         LOSS)
         VALUES (%s, %s)""", (a, b))

    print(a + "       " + str(b))

print("-----------------------")
print("Sensex Top Losers")
for i in range(1, 6):
    print(sensex[i].findAll('td')[0].text + "       " +
          str(sensex[i].findAll('td')[2].text))


db.commit()
db.close()