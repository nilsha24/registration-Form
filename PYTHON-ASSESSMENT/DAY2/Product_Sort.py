products = [
    {
        "Id": 1,"Name": "A10","Cost": 99999,"Brand": "Samsung","Category": "Electronics","Ratings": 8,"Discounts": 20
    },
    {
        "Id": 2,"Name": "Galaxy Note 10","Cost": 78999,"Brand": "Samsung","Category": "Electronics","Ratings": 9,"Discounts": 10
    },
    {
        "Id": 3,"Name": "Redmi 8","Cost": 10999,"Brand": "Xiaomi","Category": "Electronics","Ratings": 7,"Discounts": 15
    },
    {
        "Id": 4,"Name": "Jeans","Cost": 999,"Brand": "Peter England","Category": "Clothing","Ratings": 5,"Discounts": 35
    },
    {
        "Id": 5,"Name": "T-Shirt","Cost": 799,"Brand": "US-POLO","Category": "Clothing","Ratings": 7, "Discounts": 45
    }, {
        "Id": 6,"Name": "Kent RO","Cost": 23999,"Brand": "Kent","Category": "Home Appliance","Ratings": 8,"Discounts": 20
    },
    {
        "Id": 7,"Name": "ThinkPad","Cost": 45000,"Brand": "Lenovo","Category": "Electronics","Ratings": 9,"Discounts": 25
    },
    {
        "Id": 8,"Name": "Iphone 8","Cost": 29999,"Brand": "IPhone","Category": "Electronics","Ratings": 6,"Discounts": 13
    },
    {
        "Id": 9,"Name": "Asus Vivobook","Cost": 54999,"Brand": "Asus","Category": "Electronics","Ratings": 4,"Discounts": 16
    }
]

# User Input
n=int(input("Enter a no between 1-5:"))

choice =[
    [
        "Cost",
        True
    ],
    [
        "Cost",
        False
    ],
    [
        "Ratings",
        True
    ],
    [
        "Discounts",
        True
    ],
    [
        "Discounts",
        False
    ]
]


n=n-1
products.sort(key=lambda el:el[choice[n][0]],reverse=choice[n][1])

print("----------------------------")
print("Sort by :" + choice[n][0])

for product in products:
    print(product["Name"] + "---" + str(product[choice[n][0]]))