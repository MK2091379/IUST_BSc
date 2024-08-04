class SegmentTree:
    def __init__(self, arr):
        self.n = len(arr)
        self.tree = [0] * (2 * self.n)
        self.build(arr)

    def build(self, arr):
        for i in range(self.n):
            self.tree[self.n + i] = arr[i]
        for i in range(self.n - 1, 0, -1):
            self.tree[i] = self.tree[i << 1] + self.tree[i << 1 | 1]

    def update(self, i, x):
        i += self.n
        self.tree[i] = x
        while i > 1:
            i >>= 1
            self.tree[i] = self.tree[i << 1] + self.tree[i << 1 | 1]

    def query(self, l, r):
        l += self.n
        r += self.n
        res = 0
        while l <= r:
            if l & 1:
                res += self.tree[l]
                l += 1
            if not r & 1:
                res += self.tree[r]
                r -= 1
            l >>= 1
            r >>= 1
        return res

res = []
n, q = map(int, input().split())
arr = list(map(int, input().split()))
st = SegmentTree(arr)

for _ in range(q):
    query = list(map(int, input().split()))
    if query[0] == 1:
        l, r = query[1], query[2]
        res.append(st.query(l-1, r-1))
    else:
        i, x = query[1], query[2]
        st.update(i-1, x)
for i in res:
    print(i)