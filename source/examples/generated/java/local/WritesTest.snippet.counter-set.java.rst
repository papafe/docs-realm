.. code-block:: java

   realm.executeTransaction(r -> {
       house.getGhosts().set(42);
   });
