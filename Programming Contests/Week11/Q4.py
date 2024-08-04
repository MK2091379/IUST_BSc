from math import inf

def build_tree(arr, tree, start, end, index):
    if start == end:
        tree[index] = arr[start]
        return
    mid = (start + end) // 2
    build_tree(arr, tree, start, mid, 2 * index + 1)
    build_tree(arr, tree, mid + 1, end, 2 * index + 2)
    tree[index] = min(tree[2 * index + 1], tree[2 * index + 2])

def update_tree(arr, tree, start, end, index, idx, value):
    if start == end:
        arr[idx] = value
        tree[index] = value
        return
    mid = (start + end) // 2
    if idx <= mid:
        update_tree(arr, tree, start, mid, 2 * index + 1, idx, value)
    else:
        update_tree(arr, tree, mid + 1, end, 2 * index + 2,idx,value)
    tree[index] = min(tree[2 * index + 1], tree[2 * index + 2])

def query_tree(tree,start,end,l,r,index,prefix_sum):
    if r < start or l > end:
        return inf
    if l <= start and r >= end:
        return prefix_sum+tree[index]
    mid = (start+end)//2
    left = query_tree(tree,start,mid,l,r,index*2+1,prefix_sum)
    right = query_tree(tree,mid+1,end,l,r,index*2+2,prefix_sum)
    return min(left,right)

n,q = map(int,input().split())
arr = list(map(int,input().split()))
tree = [inf]*(4*n)
build_tree(arr,tree,start=0,end=n-1,index=0)
res = []
for _ in range(q):
    query = list(map(int,input().split()))
    if query[0] == 1:
        res.append(query_tree(tree,start=0,end=n-1,l=query[1]-1,r=query[2]-1,index=0,prefix_sum=0))
    else:
        update_tree(arr=arr,tree=tree,start=0,end=n-1,index=0,idx=query[1]-1,value=query[2])

for i in res:
    print(i)