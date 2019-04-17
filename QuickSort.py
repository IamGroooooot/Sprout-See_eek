def quick_sorted(x):
    if len(x) <=1:
        return x;
    pivot = [len(x)/2];
    less = [];
    more = [];
    for a in x:
        if a< pivot:
            less.append(a);
        elif a> pivot:
            more.append(a);
        else:
            equal = [a];
    return quick_sorted(less) + equal + quick_sorted(more)

x = [1,9,2,8,3,7,4,6,5,10]

print(quick_sorted(x))

input()











