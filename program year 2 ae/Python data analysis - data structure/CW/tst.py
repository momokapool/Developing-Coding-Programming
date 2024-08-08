import networkx as nx
import matplotlib.pyplot as plt

# Create the graph
MyGraph = nx.Graph(Name="Graph1", type="demo")

# Add nodes with positions
MyGraph.add_node('A', npos=(-10, 10), ccn='#00FF00')
MyGraph.add_node('B', npos=(-50, 50), ccn='#00FF00')

# Add an edge between the nodes
MyGraph.add_edge('A', 'B', cce='#00FF00')

# Get the positions
pos = {node: data['npos'] for node, data in MyGraph.nodes(data=True)}

# Draw the graph
colors = [data['ccn'] for node, data in MyGraph.nodes(data=True)]
nx.draw(MyGraph, pos, node_color=colors, with_labels=True, edge_color='#00FF00')

# Calculate midpoint for annotation
midpoint = [(pos['A'][0] + pos['B'][0]) / 2, (pos['A'][1] + pos['B'][1]) / 2]

# Annotate the distance
plt.annotate('3', midpoint, textcoords="offset points", xytext=(0,10), ha='center', color='#00FF00')

# Display the plot
plt.show()
