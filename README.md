# `AsyncKeyedLocker` default pooling locking issue

Minimal repro for a possible `AsyncKeyedLocker` pooling bug.

Run:

```powershell
dotnet test
```

Expected repro shape:

- `Cannon_AsyncLocker` fails with `Collection was modified; enumeration operation may not execute.`
- `Cannon_AsyncLocker_LockAsync` fails with the same exception.
- `Cannon_AsyncLocker_LockAsync_NoPooling` passes with `PoolSize = 0`.
- `Cannon_NativeLocker` passes.

See `OUTPUT.md` for sample output.
