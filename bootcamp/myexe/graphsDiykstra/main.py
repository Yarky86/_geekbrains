def find_lowest_cost_node(costs):
    lowest_cost = float('inf')
    lowest_cost_node = None
    for node in costs:
        cost = costs[node]
        if cost < lowest_cost and node not in processed:
            lowest_cost = cost
            lowest_cost_node = node
    return lowest_cost_node


graph = {}
graph['start'] = {}
graph['start']['a'] = 6
graph['start']['b'] = 2
graph['a'] = {}
graph['a']['end'] = 1
graph['b'] = {}
graph['b']['a'] = 3
graph['b']['end'] = 5
graph['end'] = {}
infinity = float('inf')
costs = {}
costs['a'] = 6
costs['b'] = 2
costs['end'] = infinity
parents = {}
parents['a'] = 'start'
parents['b'] = 'start'
parents['end'] = None
processed = []

node = find_lowest_cost_node(costs)
while node is not None:
    cost = costs[node]
    neighbors = graph[node]
    for n in neighbors.keys():
        new_cost = cost + neighbors[n]
        if costs[n] > new_cost:
            costs[n] = new_cost
            parents[n] = node
    processed.append(node)
    node = find_lowest_cost_node(costs)




print(graph["start"].keys())

print(graph['start']['a'])
print(graph['start']['b'])
print(costs['end'])

print(parents)
print(parents['end'])
print(parents['a'])
print(parents['b'])
print(parents[n])


# print(finish = [x for x in parents if parents.values])
# print(parents.pop('end'))
# one = parents.pop('end')
# # print(parents.pop(one))
# print(one)
# two = parents.pop(one)
# print(two)
# three = parents.pop(two)
# print(three)
# print(three, two, one)
print(parents.get('end'))
print(parents.get(parents.get('end')))
print(parents.get(parents.get(parents.get('end'))), parents.get(parents.get('end')), parents.get('end'))
