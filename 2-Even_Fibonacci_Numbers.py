_fibonacci = [1, 2]
_sum = 0

while (True):
    x = _fibonacci[-1] + _fibonacci[-2]
    if x >= 4000000:
        for i in _fibonacci:
            if i % 2 == 0:
                _sum += i
        break
    else:
        _fibonacci.append(x)
print(_sum)