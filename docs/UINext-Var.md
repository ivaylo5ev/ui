# Var
> [UI.Next Documentation](UINext.md) ▸ [API Reference](UINext-API.md) ▸ [Dataflow](UINext-Dataflow.md) ▸ **Var**

Reactive variables lay at the foundation of the [Dataflow](UINext-Dataflow.md) layer.
They can be created and manipulated just like regular `ref` cells.
Unlike `ref` cells, variables can be lifted to the [View](UINext-View.md) type to
participate in the dataflow graph.

```fsharp
namespace WebSharper.UI.Next

type Var<'T> =
    member View : View<'T>
    member Value : 'T with get, set

type Var =
    static member Create : 'T -> Var<'T>
    static member Get : Var<'T> -> 'T
    static member Set : Var<'T> -> 'T -> unit
    static member SetFinal : Var<'T> -> 'T -> unit
    static member Update : Var<'T> -> ('T -> 'T) -> unit
```

<a name="Var"></a>

[#](#Var) **Var** `type Var<'T>`

A reactive variable.

<a name="Create"></a>

[#](#Create) Var.**Create** : `'T -> Var<'T>`

Creates a fresh variable with the given initial value.

<a name="Get"></a>

[#](#Get) Var.**Get** : `Var<'T> -> 'T`

Obtains the current value.  Also available as `var.Value`.

<a name="Set"></a>

[#](#Set) Var.**Set** : `Var<'T> -> 'T -> unit`

Sets the current value.  Also available as `var.Value <- v`

<a name="SetFinal"></a>

[#](#SetFinal) Var.**SetFinal** : `Var<'T> -> 'T -> unit`

Sets the final value (after this, Set/Update are invalid).
This is rarely needed, but can help solve memory leaks when
mutliple views are scheduled to wait on a variable that is never
going to change again.

<a name="Update"></a>

[#](#Update) Var.**Update** : `Var<'T> -> ('T -> 'T) -> unit`

Updates the current value.  This is equivalent to `var.Value <- f var.Value`.

<a name="View"></a>

[#](#View) var.**View** : `View<'T>`

Lifts the variable to a [View](UINext-View.md) so that it can participate in dataflow.
