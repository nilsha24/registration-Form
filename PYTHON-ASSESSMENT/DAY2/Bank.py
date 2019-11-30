def createWallet(balance, user):

    def deposite(amount):
        nonlocal balance
        balance = balance+amount
        print(amount, " Amount deposited by " + user)
        print("Total balance " + str(balance))

    def withdraw(amount):
        nonlocal balance
        balance = balance - amount
        print(amount, " Amount withdrawn by " + user)
        print("Total balance " + str(balance))

    def showBalance():
        print("Total balance of " + user + str(balance))

    def fundsTransfer(amount, wallet, name):
        nonlocal balance
        balance = balance - amount
        print(amount, " is transferred to " + name)
        wallet[0](amount)


    return [deposite, withdraw, showBalance, fundsTransfer]


A = createWallet(43000, " MR T ")
B = createWallet(50000, " MR A")

A[0](100)
A[1](500)
A[2]()
A[3](2500, B, "B")
B[2]()
A[2]()