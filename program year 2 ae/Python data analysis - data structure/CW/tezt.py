import networkx as nx
import matplotlib.pyplot as plt

# Create a new graph
G = nx.Graph()

# Define the stations for each line
lines = {
    "Line 1": ["Station 1-1", "Station 1-2", "Station 1-3", "Station 1-4", "Station 1-5", "Station 1-6"],
    "Line 2": ["Station 2-1", "Station 2-2", "Station 2-3", "Station 2-4", "Station 2-5", "Station 2-6"],
    "Line 3": ["Station 3-1", "Station 3-2", "Station 3-3", "Station 3-4", "Station 3-5", "Station 3-6"],
    "Line 4": ["Station 4-1", "Station 4-2", "Station 4-3", "Station 4-4", "Station 4-5", "Station 4-6"]
}

# Add edges between the stations in each line
for stations in lines.values():
    edges = [(stations[i], stations[i + 1]) for i in range(len(stations) - 1)]
    G.add_edges_from(edges)

# Define the positions of the stations for visualization
pos = {}
x_offset = 0
for line, stations in lines.items():
    for i, station in enumerate(stations):
        pos[station] = (x_offset, i)
    x_offset += 1

# Draw the graph
plt.figure(figsize=(10, 8))
nx.draw(G, pos, with_labels=True, node_color='lightblue', node_size=3000, font_size=10, font_color='black', font_weight='bold', edge_color='gray')
plt.title("Piccadilly Line Map")
plt.show()
