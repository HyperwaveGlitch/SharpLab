using SharpLab.Runtime;

[JitGeneric(typeof(int))]
[JitGeneric(typeof(string))]
static class C<T> {
    [JitGeneric(typeof(int))]
    [JitGeneric(typeof(string))]
    static class N<U> {
        static T M(U u) => default(T);
    }
}

/* asm

; Core CLR <IGNORE> on amd64

C`1+N`1[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].M(Int32)
    L0000: xor eax, eax
    L0002: ret

C`1+N`1[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].M(System.__Canon)
    L0000: xor eax, eax
    L0002: ret

C`1+N`1[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].M(Int32)
    L0000: xor eax, eax
    L0002: ret

C`1+N`1[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].M(System.__Canon)
    L0000: xor eax, eax
    L0002: ret

*/