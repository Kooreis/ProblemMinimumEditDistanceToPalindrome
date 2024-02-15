def min_edit_distance(num):
    num = str(num)
    n = len(num)
    dp = [[0 for _ in range(n+1)] for _ in range(n+1)]