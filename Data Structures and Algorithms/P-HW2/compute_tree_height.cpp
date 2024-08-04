#include <bits/stdc++.h>
using namespace std;
int root=0;
int main()
{
    int number;
    cin>>number;
    vector<vector<int> >nodes(number);
    queue<int>Queue;
    int arr[number];
    for(int i=0;i<number;i++)
    {
	    cin>>arr[i];
	    if(arr[i]==-1)root=i;
	    else {
		    nodes[arr[i]].push_back(i);
	    }
    }
    Queue.push(root);
    int heightOftree=0;
    while(true)
    {
    	int Node_Count=Queue.size();
    	if(Node_Count==0){
    		cout<<heightOftree<<endl;
    		return 0;
    	}
    	    heightOftree+=1;
    	    while(Node_Count>0){
    		    int node=Queue.front();
    		    Queue.pop();
    		    if(!nodes[node].empty()){
    			    for(int i=0;i<nodes[node].size();i++)
    				    Queue.push(nodes[node][i]);
    		}
    		Node_Count--;
    	}
    }
    return 0;
}