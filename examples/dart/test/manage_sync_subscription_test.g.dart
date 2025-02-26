// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'manage_sync_subscription_test.dart';

// **************************************************************************
// RealmObjectGenerator
// **************************************************************************

class Plane extends _Plane with RealmEntity, RealmObjectBase, RealmObject {
  Plane(
    int id,
    String name,
    int numSeats,
  ) {
    RealmObjectBase.set(this, '_id', id);
    RealmObjectBase.set(this, 'name', name);
    RealmObjectBase.set(this, 'numSeats', numSeats);
  }

  Plane._();

  @override
  int get id => RealmObjectBase.get<int>(this, '_id') as int;
  @override
  set id(int value) => RealmObjectBase.set(this, '_id', value);

  @override
  String get name => RealmObjectBase.get<String>(this, 'name') as String;
  @override
  set name(String value) => RealmObjectBase.set(this, 'name', value);

  @override
  int get numSeats => RealmObjectBase.get<int>(this, 'numSeats') as int;
  @override
  set numSeats(int value) => RealmObjectBase.set(this, 'numSeats', value);

  @override
  Stream<RealmObjectChanges<Plane>> get changes =>
      RealmObjectBase.getChanges<Plane>(this);

  @override
  Plane freeze() => RealmObjectBase.freezeObject<Plane>(this);

  static SchemaObject get schema => _schema ??= _initSchema();
  static SchemaObject? _schema;
  static SchemaObject _initSchema() {
    RealmObjectBase.registerFactory(Plane._);
    return const SchemaObject(ObjectType.realmObject, Plane, 'Plane', [
      SchemaProperty('_id', RealmPropertyType.int,
          mapTo: '_id', primaryKey: true),
      SchemaProperty('name', RealmPropertyType.string),
      SchemaProperty('numSeats', RealmPropertyType.int),
    ]);
  }
}

class Train extends _Train with RealmEntity, RealmObjectBase, RealmObject {
  Train(
    int id,
    String name,
    int numCars,
  ) {
    RealmObjectBase.set(this, '_id', id);
    RealmObjectBase.set(this, 'name', name);
    RealmObjectBase.set(this, 'numCars', numCars);
  }

  Train._();

  @override
  int get id => RealmObjectBase.get<int>(this, '_id') as int;
  @override
  set id(int value) => RealmObjectBase.set(this, '_id', value);

  @override
  String get name => RealmObjectBase.get<String>(this, 'name') as String;
  @override
  set name(String value) => RealmObjectBase.set(this, 'name', value);

  @override
  int get numCars => RealmObjectBase.get<int>(this, 'numCars') as int;
  @override
  set numCars(int value) => RealmObjectBase.set(this, 'numCars', value);

  @override
  Stream<RealmObjectChanges<Train>> get changes =>
      RealmObjectBase.getChanges<Train>(this);

  @override
  Train freeze() => RealmObjectBase.freezeObject<Train>(this);

  static SchemaObject get schema => _schema ??= _initSchema();
  static SchemaObject? _schema;
  static SchemaObject _initSchema() {
    RealmObjectBase.registerFactory(Train._);
    return const SchemaObject(ObjectType.realmObject, Train, 'Train', [
      SchemaProperty('_id', RealmPropertyType.int,
          mapTo: '_id', primaryKey: true),
      SchemaProperty('name', RealmPropertyType.string),
      SchemaProperty('numCars', RealmPropertyType.int),
    ]);
  }
}

class Boat extends _Boat with RealmEntity, RealmObjectBase, RealmObject {
  Boat(
    int id,
    String name,
    int tonnage,
  ) {
    RealmObjectBase.set(this, '_id', id);
    RealmObjectBase.set(this, 'name', name);
    RealmObjectBase.set(this, 'tonnage', tonnage);
  }

  Boat._();

  @override
  int get id => RealmObjectBase.get<int>(this, '_id') as int;
  @override
  set id(int value) => RealmObjectBase.set(this, '_id', value);

  @override
  String get name => RealmObjectBase.get<String>(this, 'name') as String;
  @override
  set name(String value) => RealmObjectBase.set(this, 'name', value);

  @override
  int get tonnage => RealmObjectBase.get<int>(this, 'tonnage') as int;
  @override
  set tonnage(int value) => RealmObjectBase.set(this, 'tonnage', value);

  @override
  Stream<RealmObjectChanges<Boat>> get changes =>
      RealmObjectBase.getChanges<Boat>(this);

  @override
  Boat freeze() => RealmObjectBase.freezeObject<Boat>(this);

  static SchemaObject get schema => _schema ??= _initSchema();
  static SchemaObject? _schema;
  static SchemaObject _initSchema() {
    RealmObjectBase.registerFactory(Boat._);
    return const SchemaObject(ObjectType.realmObject, Boat, 'Boat', [
      SchemaProperty('_id', RealmPropertyType.int,
          mapTo: '_id', primaryKey: true),
      SchemaProperty('name', RealmPropertyType.string),
      SchemaProperty('tonnage', RealmPropertyType.int),
    ]);
  }
}
