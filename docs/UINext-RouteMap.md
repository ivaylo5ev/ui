# RouteMap
> [UI.Next Documentation](UINext.md) ▸ [API Reference](UINext-API.md) ▸ **RouteMap**

A RouteMap represents a bijection bewteen a URL route and a typed value.
It is used by [Router](UINext-Router.md), but can also be installed independently
to tie the browser's current hash (`document.location.href`) to a typed reactive
variable.

Routes are represented as `list<string>`.  When converting to and from URL hashes,
the framework automatically encodes the strings using `encodeUriComponent`
and `decodeUriComponent`.  All non-null values are therefore supported.

```fsharp
namespace WebSharper.UI.Next

type RouteMap<'T>
type RouteMap =
    static member Create : ('T -> list<string>) -> (list<string> -> 'T) -> RouteMap<'T>
    static member Install : RouteMap<'T> -> Var<'T>
```

<a name="RouteMap"></a>

[#](#RouteMap) **RouteMap** `type RouteMap<'T>`

A bijection between an URL route and a value of the given type.

<a name="Install"></a>

[#](#Install) RouteMap.**Install** : `RouteMap<'T> -> Var<'T>`

Installs a map to observe and modify the browser's current hash route (`document.location.hash`).
This should be called once per application, as the current URL is a shared resource.

