#include <utility>
#include <queue>
#include <iostream>
using namespace std;
#define R 10 
#define C 10

// A function to check if a given cell 
//(u, v) can be included in DFS 
bool isSafe(int mat[R][C], int i, int j,
    bool vis[R][C])
{
    return (i >= 0) && (i < R) &&
        (j >= 0) && (j < C) &&
        (mat[i][j] && !vis[i][j]);
}

void BFS(int mat[R][C], bool vis[R][C],
    int si, int sj)
{

    // These arrays are used to get row and 
    // column numbers of 8 neighbours of 
    // a given cell 
    int row[] = { -1, -1, -1, 0, 0, 1, 1, 1 };
    int col[] = { -1, 0, 1, -1, 1, -1, 0, 1 };

    // Simple BFS first step, we enqueue 
    // source and mark it as visited 
    queue<pair<int, int> > q;
    q.push(make_pair(si, sj));
    vis[si][sj] = true;

    // Next step of BFS. We take out 
    // items one by one from queue and 
    // enqueue their univisited adjacent 
    while (!q.empty()) {

        int i = q.front().first;
        int j = q.front().second;
        q.pop();

        // Go through all 8 adjacent 
        for (int k = 0; k < 8; k++) {
            if (isSafe(mat, i + row[k],
                j + col[k], vis)) {
                vis[i + row[k]][j + col[k]] = true;
                q.push(make_pair(i + row[k], j + col[k]));
            }
        }
    }
}

// This function returns number islands (connected 
// components) in a graph. It simply works as  
// BFS for disconnected graph and returns count 
// of BFS calls. 
int countIslands(int mat[R][C])
{
    // Mark all cells as not visited 
    bool vis[R][C];
    memset(vis, 0, sizeof(vis));

    // Call BFS for every unvisited vertex 
    // Whenever we see an univisted vertex, 
    // we increment res (number of islands) 
    // also. 
    int res = 0;
    for (int i = 0; i < R; i++) {
        for (int j = 0; j < C; j++) {
            if (mat[i][j] && !vis[i][j]) {
                BFS(mat, vis, i, j);
                res++;
            }
        }
    }

    return res;
}

// main function 
int main()
{
    int mat[][C] = { { 1,0,1,0,0,0,1,1,1,1 },
                     { 0,0,1,0,0,0,1,0,0,0 },
                     { 1,1,1,1,0,0,1,0,0,0 },
                     { 1,0,0,1,0,0,0,0,0,0 },
                     { 1,1,1,1,0,0,0,1,1,1 },                       
                     { 0,1,0,1,0,0,1,1,1,1 } };

    cout << countIslands(mat);

    return 0;
}