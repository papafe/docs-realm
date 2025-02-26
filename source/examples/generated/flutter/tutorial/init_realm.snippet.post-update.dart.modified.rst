.. code-block:: dart
   :caption: lib/realm/init_realm.dart
   :emphasize-lines: 1, 1, 1, 1, 5-6, 8, 13-15, 18-22, 5-6, 8, 13-15, 18-22

   // old subscriptions
   final userItemSub = realm.subscriptions.findByName('getUserItems');
   final userItemSubWithPriority =
       realm.subscriptions.findByName('getUserItemsWithPriority');
   final userItemSubWithPriorityOrNothing =
       realm.subscriptions.findByName('getUserItemsWithPriorityOrNothing');

   if (userItemSubWithPriorityOrNothing == null) {
     realm.subscriptions.update((mutableSubscriptions) {
       if (userItemSub != null) {
         mutableSubscriptions.remove(userItemSub);
       }
       if (userItemSubWithPriority != null) {
         mutableSubscriptions.remove(userItemSubWithPriority);
       }
       // server-side rules ensure user only downloads own items
       mutableSubscriptions.add(
           realm.query<Item>(
             'priority <= \$0 OR priority == nil',
             [PriorityLevel.high],
           ),
           name: 'getUserItemsWithPriorityOrNothing');
     });
     // Syncs in background
     // realm.subscriptions.waitForSynchronization();
   }
