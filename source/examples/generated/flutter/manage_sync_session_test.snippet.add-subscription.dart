final planeQuery = realm.all<Plane>();
final longTrainQuery = realm.all<Train>().query("numCars >= 4");
realm.subscriptions.update((MutableSubscriptionSet mutableSubscriptions) {
  mutableSubscriptions.add(planeQuery, name: "all-planes");
  mutableSubscriptions.add(longTrainQuery,
      name: 'long-trains', update: true);
});
await realm.subscriptions.waitForSynchronization();
