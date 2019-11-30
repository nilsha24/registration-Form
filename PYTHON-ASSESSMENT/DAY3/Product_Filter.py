class Products:

    def __init__(self, id, name, cost, brand, category, ratings, discounts):
        self.Id = id
        self.Name = name
        self.Cost = cost
        self.Brand = brand
        self.Category = category
        self.Ratings = ratings
        self.Discounts = discounts

    def __str__(self):
        return str(self.Name + "---------" + str(self.Cost) + str(self.Ratings) + str(self.Discounts))


p1 = Products(1, "A 10", 9999, "Samsung", "Electronics", 8, 20)
p2 = Products(2, "L-24 ", 8799, "Lenevo", "Electronics", 9, 25)
p3 = Products(3, "Jeans", 3999, "Roadstar", "Clothing", 4, 43)
p4 = Products(4, "Iphone 10", 2399, "Iphone", "Electronics", 3, 21)
p5 = Products(4, "Redmi 8", 2399, "Xiaomi", "Electronics", 7, 15)

productsList = [
    p1,
    p2,
    p3,
    p4,
    p5
]

productsList.sort(key=lambda el: el.Cost)

print("----------------------------")


for product in productsList:
    print(
        product
    )