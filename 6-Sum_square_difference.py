a = pow(sum(range(101)), 2) #square of the sum
b = 0  #sum of the squares
for i in range(101):
    b += i * i

print(a - b) #25164150
