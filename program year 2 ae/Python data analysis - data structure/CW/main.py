import networkx as nx
import matplotlib.pyplot as plt

MyGraph = nx.Graph(Name="Graph1",type="demo")

#First line: dark blue line: Piccaddly
MyGraph.add_node('Hyde Park Corner', npos=(3, 4), ccn='#00008B')
MyGraph.add_node('Green Park', npos=(4, 5), ccn='#00008B')
MyGraph.add_node('Piccadlly Circus', npos=(5.5 , 5), ccn='#00008B')
MyGraph.add_node('Leicester Square', npos=(6, 6), ccn='#00008B')
MyGraph.add_node('Convent Garden', npos=(7, 7), ccn='#00008B')
MyGraph.add_node('Holborn', npos=(8, 8), ccn='#00008B')

###Second line: red: Central
MyGraph.add_node('Lancaster Gate', npos=(2, 8), ccn='#FF0000')
MyGraph.add_node('Marble Arch', npos=(3, 8), ccn='#FF0000')
MyGraph.add_node('Bond Street', npos=(4, 8), ccn='#FF0000')
MyGraph.add_node('Oxford Cirtrus', npos=(5, 8), ccn='#FF0000')
MyGraph.add_node('Totteham Court Road', npos=(6, 8), ccn='#FF0000')
#MyGraph.add_node('Holborn', npos=(8, 8), ccn='#00008B')

###Third line: brown: Bakerloo
MyGraph.add_node('Edware Road', npos=(1, 10), ccn='#A52A2A')
MyGraph.add_node('Marylebone', npos=(2, 10), ccn='#A52A2A')
MyGraph.add_node('Regent Park', npos=(4, 9), ccn='#A52A2A')
#MyGraph.add_node('Oxford Cirtrus', npos=(5, 8), ccn='#FF0000')
#MyGraph.add_node('Piccadlly Circus', npos=(5.5, 5), ccn='#00008B')
MyGraph.add_node('Charring Cross', npos=(6, 4), ccn='#A52A2A')

###Fourth line: light blue: Victoria
MyGraph.add_node('Plimico', npos=(4, 0), ccn='#ADD8E6')
MyGraph.add_node('Victoria', npos=(4, 2), ccn='#ADD8E6')
#MyGraph.add_node('Green Park', npos=(4, 5), ccn='#00008B')
#MyGraph.add_node('Oxford Cirtrus', npos=(5, 8), ccn='#FF0000')
MyGraph.add_node('Warren Street', npos=(6, 9), ccn='#ADD8E6')
MyGraph.add_node('King Cross', npos=(8, 11), ccn='#ADD8E6')


##DarkBlueLine
MyGraph.add_edge('Hyde Park Corner', 'Green Park', cce='#00008B')
MyGraph.add_edge('Green Park', 'Piccadlly Circus', cce='#00008B')
MyGraph.add_edge('Piccadlly Circus', 'Leicester Square', cce='#00008B')
MyGraph.add_edge('Leicester Square', 'Convent Garden', cce='#00008B')
MyGraph.add_edge('Convent Garden', 'Holborn', cce='#00008B')