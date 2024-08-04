n, m = map(int, input().split())
a = list(map(int, input().split()))

def build_tree(node, start, end):
    if start == end:
        tree[node] = a[start]
    else:
        mid = (start + end) // 2
        build_tree(2 * node + 1, start, mid)
        build_tree(2 * node + 2, mid + 1, end)
        tree[node] = min(tree[2 * node + 1], tree[2 * node + 2])

def update_tree(node, start, end, idx, val):
    if start == end:
        a[idx] = val
        tree[node] = val
    else:
        mid = (start + end) // 2
        if start <= idx <= mid:
            update_tree(2 * node + 1, start, mid, idx, val)
        else:
            update_tree(2 * node + 2, mid + 1, end, idx, val)
        tree[node] = min(tree[2 * node + 1], tree[2 * node + 2])

def query_tree(node, start, end, l, r):
    if r < start or end < l:
        return float('inf')
    if l <= start and end <= r:
        return tree[node]
    mid = (start + end) // 2
    p1 = query_tree(2 * node + 1, start, mid, l, r)
    p2 = query_tree(2 * node + 2, mid + 1, end, l ,r)
    return min(p1,p2)

tree = [0] * (4 * n)
build_tree(0 ,0 ,n - 1)
res = []
for _ in range(m):
    q,x,y = map(int,input().split())
    if q == 1:
        res.append(query_tree(0 ,0 ,n - 1 ,x - 1 ,y - 1))
    else:
        update_tree(0 ,0 ,n - 1 ,x - 1 ,y)
for i in res:
    print(i)