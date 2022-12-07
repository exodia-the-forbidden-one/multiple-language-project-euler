
def multiples_generator(n):
    # returns multiples of 3 and 6 within "n" range
    for i in range(n):
        if i % 3 == 0 or i % 5 == 0:
            yield i

print(sum(multiples_generator(1000)))
