; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$.ctor
; RVA 0x5B06D78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06D78  str      x30, [sp, #-0x30]!
005B06D7C  stp      x22, x21, [sp, #0x10]
005B06D80  stp      x20, x19, [sp, #0x20]
005B06D84  ldr      x8, [x4, #0x20]
005B06D88  mov      x21, x1
005B06D8C  mov      x19, x3
005B06D90  mov      x20, x2
005B06D94  ldr      x8, [x8, #0xc0]
005B06D98  mov      x22, x0
005B06D9C  ldr      x1, [x8]
005B06DA0  bl       #0x4a749e8 ; System.Linq.Enumerable.Iterator<object>$$.ctor
005B06DA4  mov      x0, x22
005B06DA8  str      x21, [x0, #0x20]!
005B06DAC  mov      x1, x21
005B06DB0  bl       #0x382bcb8 ; 
005B06DB4  mov      x0, x22
005B06DB8  str      x20, [x0, #0x28]!
005B06DBC  mov      x1, x20
005B06DC0  bl       #0x382bcb8 ; 
005B06DC4  str      x19, [x22, #0x30]!
005B06DC8  mov      x0, x22
005B06DCC  mov      x1, x19
005B06DD0  ldp      x20, x19, [sp, #0x20]
005B06DD4  ldp      x22, x21, [sp, #0x10]
005B06DD8  ldr      x30, [sp], #0x30
005B06DDC  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Clone
; RVA 0x5B06DE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06DE0  str      x30, [sp, #-0x30]!
005B06DE4  stp      x22, x21, [sp, #0x10]
005B06DE8  stp      x20, x19, [sp, #0x20]
005B06DEC  ldr      x9, [x1, #0x20]
005B06DF0  mov      x8, x0
005B06DF4  ldp      x21, x20, [x8, #0x20]
005B06DF8  ldr      x22, [x8, #0x30]
005B06DFC  ldr      x9, [x9, #0xc0]
005B06E00  mov      x19, x1
005B06E04  ldr      x0, [x9, #0x18]
005B06E08  ldrb     w9, [x0, #0x135]
005B06E0C  tbnz     w9, #0, #0x5b06e14
005B06E10  bl       #0x3a7e60c ; 
005B06E14  bl       #0x382bfa0 ; 
005B06E18  ldr      x8, [x19, #0x20]
005B06E1C  mov      x1, x21
005B06E20  mov      x2, x20
005B06E24  mov      x3, x22
005B06E28  ldr      x8, [x8, #0xc0]
005B06E2C  mov      x19, x0
005B06E30  ldr      x4, [x8, #0x30]
005B06E34  bl       #0x5b06d78 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$.ctor
005B06E38  mov      x0, x19
005B06E3C  ldp      x20, x19, [sp, #0x20]
005B06E40  ldp      x22, x21, [sp, #0x10]
005B06E44  ldr      x30, [sp], #0x30
005B06E48  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$MoveNext
; RVA 0x5B06E4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06E4C  sub      sp, sp, #0x110
005B06E50  stp      x29, x30, [sp, #0xe0]
005B06E54  stp      x22, x21, [sp, #0xf0]
005B06E58  stp      x20, x19, [sp, #0x100]
005B06E5C  ldr      w8, [x0, #0x14]
005B06E60  mov      x19, x0
005B06E64  mov      x20, x1
005B06E68  cmp      w8, #2
005B06E6C  b.eq     #0x5b06ecc
005B06E70  cmp      w8, #1
005B06E74  b.ne     #0x5b06fb0
005B06E78  ldr      x0, [x19, #0x20]
005B06E7C  cbz      x0, #0x5b06fc8
005B06E80  ldr      x8, [x20, #0x20]
005B06E84  ldr      x8, [x8, #0xc0]
005B06E88  ldr      x1, [x8, #0x40]
005B06E8C  add      x8, sp, #0x40
005B06E90  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B06E94  add      x0, sp, #0x90
005B06E98  add      x1, sp, #0x40
005B06E9C  mov      w2, #0x48
005B06EA0  bl       #0x89edad0 ; 
005B06EA4  add      x21, x19, #0x38
005B06EA8  add      x1, sp, #0x90
005B06EAC  mov      w2, #0x48
005B06EB0  mov      x0, x21
005B06EB4  bl       #0x89edad0 ; 
005B06EB8  mov      x0, x21
005B06EBC  mov      x1, xzr
005B06EC0  bl       #0x382bcb8 ; 
005B06EC4  mov      w8, #2
005B06EC8  str      w8, [x19, #0x14]
005B06ECC  add      x21, x19, #0x38
005B06ED0  add      x22, x19, #0x48
005B06ED4  ldr      x8, [x20, #0x20]
005B06ED8  mov      x0, x21
005B06EDC  ldr      x8, [x8, #0xc0]
005B06EE0  ldr      x1, [x8, #0x80]
005B06EE4  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B06EE8  tbz      w0, #0, #0x5b06fa0
005B06EEC  ldr      x8, [x22, #0x30]
005B06EF0  ldp      q1, q0, [x22, #0x10]
005B06EF4  ldr      q2, [x22]
005B06EF8  str      x8, [sp, #0x70]
005B06EFC  stp      q1, q0, [sp, #0x50]
005B06F00  str      q2, [sp, #0x40]
005B06F04  ldr      x8, [x19, #0x28]
005B06F08  cbz      x8, #0x5b06f3c
005B06F0C  ldp      q0, q1, [sp, #0x40]
005B06F10  ldr      q2, [sp, #0x60]
005B06F14  ldr      x10, [sp, #0x70]
005B06F18  ldr      x9, [x8, #0x18]
005B06F1C  ldr      x0, [x8, #0x40]
005B06F20  stp      q0, q1, [sp, #0x90]
005B06F24  str      q2, [sp, #0xb0]
005B06F28  str      x10, [sp, #0xc0]
005B06F2C  ldr      x2, [x8, #0x28]
005B06F30  add      x1, sp, #0x90
005B06F34  blr      x9
005B06F38  tbz      w0, #0, #0x5b06ed4
005B06F3C  ldr      x8, [x19, #0x30]
005B06F40  ldp      q0, q1, [sp, #0x40]
005B06F44  ldr      q2, [sp, #0x60]
005B06F48  ldr      x9, [sp, #0x70]
005B06F4C  stp      q0, q1, [sp]
005B06F50  str      q2, [sp, #0x20]
005B06F54  str      x9, [sp, #0x30]
005B06F58  cbz      x8, #0x5b06fc8
005B06F5C  ldp      q0, q1, [sp]
005B06F60  ldr      q2, [sp, #0x20]
005B06F64  ldr      x10, [sp, #0x30]
005B06F68  ldr      x9, [x8, #0x18]
005B06F6C  ldr      x0, [x8, #0x40]
005B06F70  stp      q0, q1, [sp, #0x90]
005B06F74  str      q2, [sp, #0xb0]
005B06F78  str      x10, [sp, #0xc0]
005B06F7C  ldr      x2, [x8, #0x28]
005B06F80  add      x1, sp, #0x90
005B06F84  blr      x9
005B06F88  str      x0, [x19, #0x18]!
005B06F8C  mov      x1, x0
005B06F90  mov      x0, x19
005B06F94  bl       #0x382bcb8 ; 
005B06F98  mov      w0, #1
005B06F9C  b        #0x5b06fb4 ; 
005B06FA0  ldr      x8, [x19]
005B06FA4  mov      x0, x19
005B06FA8  ldp      x9, x1, [x8, #0x1f8]
005B06FAC  blr      x9
005B06FB0  mov      w0, wzr
005B06FB4  ldp      x20, x19, [sp, #0x100]
005B06FB8  ldp      x22, x21, [sp, #0xf0]
005B06FBC  ldp      x29, x30, [sp, #0xe0]
005B06FC0  add      sp, sp, #0x110
005B06FC4  ret      
005B06FC8  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<ValueTuple<int, int>>
; RVA 0x44B3004; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B3004  stp      x30, x23, [sp, #-0x30]!
0044B3008  stp      x22, x21, [sp, #0x10]
0044B300C  stp      x20, x19, [sp, #0x20]
0044B3010  ldr      x8, [x2, #0x38]
0044B3014  mov      x19, x2
0044B3018  mov      x22, x1
0044B301C  mov      x23, x0
0044B3020  cbnz     x8, #0x44b3030
0044B3024  mov      x0, x19
0044B3028  bl       #0x3a7e668 ; 
0044B302C  ldr      x8, [x19, #0x38]
0044B3030  ldr      x0, [x23, #0x30]
0044B3034  ldr      x2, [x8, #8]
0044B3038  ldp      x20, x21, [x23, #0x20]
0044B303C  mov      x1, x22
0044B3040  bl       #0x45a0930 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, ValueTuple<int, int>>
0044B3044  ldr      x8, [x19, #0x38]
0044B3048  mov      x22, x0
0044B304C  ldr      x8, [x8, #0x18]
0044B3050  ldrb     w9, [x8, #0x135]
0044B3054  tbnz     w9, #0, #0x44b3064
0044B3058  mov      x0, x8
0044B305C  bl       #0x3a7e60c ; 
0044B3060  mov      x8, x0
0044B3064  mov      x0, x8
0044B3068  bl       #0x382bfa0 ; 
0044B306C  ldr      x8, [x19, #0x38]
0044B3070  mov      x1, x20
0044B3074  mov      x2, x21
0044B3078  mov      x3, x22
0044B307C  ldr      x4, [x8, #0x20]
0044B3080  mov      x19, x0
0044B3084  bl       #0x5b04a2c ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
0044B3088  mov      x0, x19
0044B308C  ldp      x20, x19, [sp, #0x20]
0044B3090  ldp      x22, x21, [sp, #0x10]
0044B3094  ldp      x30, x23, [sp], #0x30
0044B3098  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<AttributeOneElement>
; RVA 0x44B309C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B309C  stp      x30, x23, [sp, #-0x30]!
0044B30A0  stp      x22, x21, [sp, #0x10]
0044B30A4  stp      x20, x19, [sp, #0x20]
0044B30A8  ldr      x8, [x2, #0x38]
0044B30AC  mov      x19, x2
0044B30B0  mov      x22, x1
0044B30B4  mov      x23, x0
0044B30B8  cbnz     x8, #0x44b30c8
0044B30BC  mov      x0, x19
0044B30C0  bl       #0x3a7e668 ; 
0044B30C4  ldr      x8, [x19, #0x38]
0044B30C8  ldr      x0, [x23, #0x30]
0044B30CC  ldr      x2, [x8, #8]
0044B30D0  ldp      x20, x21, [x23, #0x20]
0044B30D4  mov      x1, x22
0044B30D8  bl       #0x45a09ec ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, AttributeOneElement>
0044B30DC  ldr      x8, [x19, #0x38]
0044B30E0  mov      x22, x0
0044B30E4  ldr      x8, [x8, #0x18]
0044B30E8  ldrb     w9, [x8, #0x135]
0044B30EC  tbnz     w9, #0, #0x44b30fc
0044B30F0  mov      x0, x8
0044B30F4  bl       #0x3a7e60c ; 
0044B30F8  mov      x8, x0
0044B30FC  mov      x0, x8
0044B3100  bl       #0x382bfa0 ; 
0044B3104  ldr      x8, [x19, #0x38]
0044B3108  mov      x1, x20
0044B310C  mov      x2, x21
0044B3110  mov      x3, x22
0044B3114  ldr      x4, [x8, #0x20]
0044B3118  mov      x19, x0
0044B311C  bl       #0x5b04cdc ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, AttributeOneElement>$$.ctor
0044B3120  mov      x0, x19
0044B3124  ldp      x20, x19, [sp, #0x20]
0044B3128  ldp      x22, x21, [sp, #0x10]
0044B312C  ldp      x30, x23, [sp], #0x30
0044B3130  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<bool>
; RVA 0x44B3134; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B3134  stp      x30, x23, [sp, #-0x30]!
0044B3138  stp      x22, x21, [sp, #0x10]
0044B313C  stp      x20, x19, [sp, #0x20]
0044B3140  ldr      x8, [x2, #0x38]
0044B3144  mov      x19, x2
0044B3148  mov      x22, x1
0044B314C  mov      x23, x0
0044B3150  cbnz     x8, #0x44b3160
0044B3154  mov      x0, x19
0044B3158  bl       #0x3a7e668 ; 
0044B315C  ldr      x8, [x19, #0x38]
0044B3160  ldr      x0, [x23, #0x30]
0044B3164  ldr      x2, [x8, #8]
0044B3168  ldp      x20, x21, [x23, #0x20]
0044B316C  mov      x1, x22
0044B3170  bl       #0x45a0aa8 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, bool>
0044B3174  ldr      x8, [x19, #0x38]
0044B3178  mov      x22, x0
0044B317C  ldr      x8, [x8, #0x18]
0044B3180  ldrb     w9, [x8, #0x135]
0044B3184  tbnz     w9, #0, #0x44b3194
0044B3188  mov      x0, x8
0044B318C  bl       #0x3a7e60c ; 
0044B3190  mov      x8, x0
0044B3194  mov      x0, x8
0044B3198  bl       #0x382bfa0 ; 
0044B319C  ldr      x8, [x19, #0x38]
0044B31A0  mov      x1, x20
0044B31A4  mov      x2, x21
0044B31A8  mov      x3, x22
0044B31AC  ldr      x4, [x8, #0x20]
0044B31B0  mov      x19, x0
0044B31B4  bl       #0x5b04fbc ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, bool>$$.ctor
0044B31B8  mov      x0, x19
0044B31BC  ldp      x20, x19, [sp, #0x20]
0044B31C0  ldp      x22, x21, [sp, #0x10]
0044B31C4  ldp      x30, x23, [sp], #0x30
0044B31C8  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<CalAttrCardData>
; RVA 0x44B31CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B31CC  stp      x30, x23, [sp, #-0x30]!
0044B31D0  stp      x22, x21, [sp, #0x10]
0044B31D4  stp      x20, x19, [sp, #0x20]
0044B31D8  ldr      x8, [x2, #0x38]
0044B31DC  mov      x19, x2
0044B31E0  mov      x22, x1
0044B31E4  mov      x23, x0
0044B31E8  cbnz     x8, #0x44b31f8
0044B31EC  mov      x0, x19
0044B31F0  bl       #0x3a7e668 ; 
0044B31F4  ldr      x8, [x19, #0x38]
0044B31F8  ldr      x0, [x23, #0x30]
0044B31FC  ldr      x2, [x8, #8]
0044B3200  ldp      x20, x21, [x23, #0x20]
0044B3204  mov      x1, x22
0044B3208  bl       #0x45a0b64 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalAttrCardData>
0044B320C  ldr      x8, [x19, #0x38]
0044B3210  mov      x22, x0
0044B3214  ldr      x8, [x8, #0x18]
0044B3218  ldrb     w9, [x8, #0x135]
0044B321C  tbnz     w9, #0, #0x44b322c
0044B3220  mov      x0, x8
0044B3224  bl       #0x3a7e60c ; 
0044B3228  mov      x8, x0
0044B322C  mov      x0, x8
0044B3230  bl       #0x382bfa0 ; 
0044B3234  ldr      x8, [x19, #0x38]
0044B3238  mov      x1, x20
0044B323C  mov      x2, x21
0044B3240  mov      x3, x22
0044B3244  ldr      x4, [x8, #0x20]
0044B3248  mov      x19, x0
0044B324C  bl       #0x5b05270 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrCardData>$$.ctor
0044B3250  mov      x0, x19
0044B3254  ldp      x20, x19, [sp, #0x20]
0044B3258  ldp      x22, x21, [sp, #0x10]
0044B325C  ldp      x30, x23, [sp], #0x30
0044B3260  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<CalAttrRelicData>
; RVA 0x44B3264; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B3264  stp      x30, x23, [sp, #-0x30]!
0044B3268  stp      x22, x21, [sp, #0x10]
0044B326C  stp      x20, x19, [sp, #0x20]
0044B3270  ldr      x8, [x2, #0x38]
0044B3274  mov      x19, x2
0044B3278  mov      x22, x1
0044B327C  mov      x23, x0
0044B3280  cbnz     x8, #0x44b3290
0044B3284  mov      x0, x19
0044B3288  bl       #0x3a7e668 ; 
0044B328C  ldr      x8, [x19, #0x38]
0044B3290  ldr      x0, [x23, #0x30]
0044B3294  ldr      x2, [x8, #8]
0044B3298  ldp      x20, x21, [x23, #0x20]
0044B329C  mov      x1, x22
0044B32A0  bl       #0x45a0c20 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalAttrRelicData>
0044B32A4  ldr      x8, [x19, #0x38]
0044B32A8  mov      x22, x0
0044B32AC  ldr      x8, [x8, #0x18]
0044B32B0  ldrb     w9, [x8, #0x135]
0044B32B4  tbnz     w9, #0, #0x44b32c4
0044B32B8  mov      x0, x8
0044B32BC  bl       #0x3a7e60c ; 
0044B32C0  mov      x8, x0
0044B32C4  mov      x0, x8
0044B32C8  bl       #0x382bfa0 ; 
0044B32CC  ldr      x8, [x19, #0x38]
0044B32D0  mov      x1, x20
0044B32D4  mov      x2, x21
0044B32D8  mov      x3, x22
0044B32DC  ldr      x4, [x8, #0x20]
0044B32E0  mov      x19, x0
0044B32E4  bl       #0x5b05520 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrRelicData>$$.ctor
0044B32E8  mov      x0, x19
0044B32EC  ldp      x20, x19, [sp, #0x20]
0044B32F0  ldp      x22, x21, [sp, #0x10]
0044B32F4  ldp      x30, x23, [sp], #0x30
0044B32F8  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<CalCollectionTreasureData>
; RVA 0x44B32FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B32FC  stp      x30, x23, [sp, #-0x30]!
0044B3300  stp      x22, x21, [sp, #0x10]
0044B3304  stp      x20, x19, [sp, #0x20]
0044B3308  ldr      x8, [x2, #0x38]
0044B330C  mov      x19, x2
0044B3310  mov      x22, x1
0044B3314  mov      x23, x0
0044B3318  cbnz     x8, #0x44b3328
0044B331C  mov      x0, x19
0044B3320  bl       #0x3a7e668 ; 
0044B3324  ldr      x8, [x19, #0x38]
0044B3328  ldr      x0, [x23, #0x30]
0044B332C  ldr      x2, [x8, #8]
0044B3330  ldp      x20, x21, [x23, #0x20]
0044B3334  mov      x1, x22
0044B3338  bl       #0x45a0cdc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalCollectionTreasureData>
0044B333C  ldr      x8, [x19, #0x38]
0044B3340  mov      x22, x0
0044B3344  ldr      x8, [x8, #0x18]
0044B3348  ldrb     w9, [x8, #0x135]
0044B334C  tbnz     w9, #0, #0x44b335c
0044B3350  mov      x0, x8
0044B3354  bl       #0x3a7e60c ; 
0044B3358  mov      x8, x0
0044B335C  mov      x0, x8
0044B3360  bl       #0x382bfa0 ; 
0044B3364  ldr      x8, [x19, #0x38]
0044B3368  mov      x1, x20
0044B336C  mov      x2, x21
0044B3370  mov      x3, x22
0044B3374  ldr      x4, [x8, #0x20]
0044B3378  mov      x19, x0
0044B337C  bl       #0x5b057d0 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
0044B3380  mov      x0, x19
0044B3384  ldp      x20, x19, [sp, #0x20]
0044B3388  ldp      x22, x21, [sp, #0x10]
0044B338C  ldp      x30, x23, [sp], #0x30
0044B3390  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<CalEquipData>
; RVA 0x44B3394; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B3394  stp      x30, x23, [sp, #-0x30]!
0044B3398  stp      x22, x21, [sp, #0x10]
0044B339C  stp      x20, x19, [sp, #0x20]
0044B33A0  ldr      x8, [x2, #0x38]
0044B33A4  mov      x19, x2
0044B33A8  mov      x22, x1
0044B33AC  mov      x23, x0
0044B33B0  cbnz     x8, #0x44b33c0
0044B33B4  mov      x0, x19
0044B33B8  bl       #0x3a7e668 ; 
0044B33BC  ldr      x8, [x19, #0x38]
0044B33C0  ldr      x0, [x23, #0x30]
0044B33C4  ldr      x2, [x8, #8]
0044B33C8  ldp      x20, x21, [x23, #0x20]
0044B33CC  mov      x1, x22
0044B33D0  bl       #0x45a0d98 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalEquipData>
0044B33D4  ldr      x8, [x19, #0x38]
0044B33D8  mov      x22, x0
0044B33DC  ldr      x8, [x8, #0x18]
0044B33E0  ldrb     w9, [x8, #0x135]
0044B33E4  tbnz     w9, #0, #0x44b33f4
0044B33E8  mov      x0, x8
0044B33EC  bl       #0x3a7e60c ; 
0044B33F0  mov      x8, x0
0044B33F4  mov      x0, x8
0044B33F8  bl       #0x382bfa0 ; 
0044B33FC  ldr      x8, [x19, #0x38]
0044B3400  mov      x1, x20
0044B3404  mov      x2, x21
0044B3408  mov      x3, x22
0044B340C  ldr      x4, [x8, #0x20]
0044B3410  mov      x19, x0
0044B3414  bl       #0x5b05a80 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalEquipData>$$.ctor
0044B3418  mov      x0, x19
0044B341C  ldp      x20, x19, [sp, #0x20]
0044B3420  ldp      x22, x21, [sp, #0x10]
0044B3424  ldp      x30, x23, [sp], #0x30
0044B3428  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<CalRoleData>
; RVA 0x44B342C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B342C  stp      x30, x23, [sp, #-0x30]!
0044B3430  stp      x22, x21, [sp, #0x10]
0044B3434  stp      x20, x19, [sp, #0x20]
0044B3438  ldr      x8, [x2, #0x38]
0044B343C  mov      x19, x2
0044B3440  mov      x22, x1
0044B3444  mov      x23, x0
0044B3448  cbnz     x8, #0x44b3458
0044B344C  mov      x0, x19
0044B3450  bl       #0x3a7e668 ; 
0044B3454  ldr      x8, [x19, #0x38]
0044B3458  ldr      x0, [x23, #0x30]
0044B345C  ldr      x2, [x8, #8]
0044B3460  ldp      x20, x21, [x23, #0x20]
0044B3464  mov      x1, x22
0044B3468  bl       #0x45a0e54 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalRoleData>
0044B346C  ldr      x8, [x19, #0x38]
0044B3470  mov      x22, x0
0044B3474  ldr      x8, [x8, #0x18]
0044B3478  ldrb     w9, [x8, #0x135]
0044B347C  tbnz     w9, #0, #0x44b348c
0044B3480  mov      x0, x8
0044B3484  bl       #0x3a7e60c ; 
0044B3488  mov      x8, x0
0044B348C  mov      x0, x8
0044B3490  bl       #0x382bfa0 ; 
0044B3494  ldr      x8, [x19, #0x38]
0044B3498  mov      x1, x20
0044B349C  mov      x2, x21
0044B34A0  mov      x3, x22
0044B34A4  ldr      x4, [x8, #0x20]
0044B34A8  mov      x19, x0
0044B34AC  bl       #0x5b05d30 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRoleData>$$.ctor
0044B34B0  mov      x0, x19
0044B34B4  ldp      x20, x19, [sp, #0x20]
0044B34B8  ldp      x22, x21, [sp, #0x10]
0044B34BC  ldp      x30, x23, [sp], #0x30
0044B34C0  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<CalRuneData>
; RVA 0x44B34C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B34C4  stp      x30, x23, [sp, #-0x30]!
0044B34C8  stp      x22, x21, [sp, #0x10]
0044B34CC  stp      x20, x19, [sp, #0x20]
0044B34D0  ldr      x8, [x2, #0x38]
0044B34D4  mov      x19, x2
0044B34D8  mov      x22, x1
0044B34DC  mov      x23, x0
0044B34E0  cbnz     x8, #0x44b34f0
0044B34E4  mov      x0, x19
0044B34E8  bl       #0x3a7e668 ; 
0044B34EC  ldr      x8, [x19, #0x38]
0044B34F0  ldr      x0, [x23, #0x30]
0044B34F4  ldr      x2, [x8, #8]
0044B34F8  ldp      x20, x21, [x23, #0x20]
0044B34FC  mov      x1, x22
0044B3500  bl       #0x45a0f10 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalRuneData>
0044B3504  ldr      x8, [x19, #0x38]
0044B3508  mov      x22, x0
0044B350C  ldr      x8, [x8, #0x18]
0044B3510  ldrb     w9, [x8, #0x135]
0044B3514  tbnz     w9, #0, #0x44b3524
0044B3518  mov      x0, x8
0044B351C  bl       #0x3a7e60c ; 
0044B3520  mov      x8, x0
0044B3524  mov      x0, x8
0044B3528  bl       #0x382bfa0 ; 
0044B352C  ldr      x8, [x19, #0x38]
0044B3530  mov      x1, x20
0044B3534  mov      x2, x21
0044B3538  mov      x3, x22
0044B353C  ldr      x4, [x8, #0x20]
0044B3540  mov      x19, x0
0044B3544  bl       #0x5b06008 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRuneData>$$.ctor
0044B3548  mov      x0, x19
0044B354C  ldp      x20, x19, [sp, #0x20]
0044B3550  ldp      x22, x21, [sp, #0x10]
0044B3554  ldp      x30, x23, [sp], #0x30
0044B3558  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<char>
; RVA 0x44B355C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B355C  stp      x30, x23, [sp, #-0x30]!
0044B3560  stp      x22, x21, [sp, #0x10]
0044B3564  stp      x20, x19, [sp, #0x20]
0044B3568  ldr      x8, [x2, #0x38]
0044B356C  mov      x19, x2
0044B3570  mov      x22, x1
0044B3574  mov      x23, x0
0044B3578  cbnz     x8, #0x44b3588
0044B357C  mov      x0, x19
0044B3580  bl       #0x3a7e668 ; 
0044B3584  ldr      x8, [x19, #0x38]
0044B3588  ldr      x0, [x23, #0x30]
0044B358C  ldr      x2, [x8, #8]
0044B3590  ldp      x20, x21, [x23, #0x20]
0044B3594  mov      x1, x22
0044B3598  bl       #0x45a0fcc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, char>
0044B359C  ldr      x8, [x19, #0x38]
0044B35A0  mov      x22, x0
0044B35A4  ldr      x8, [x8, #0x18]
0044B35A8  ldrb     w9, [x8, #0x135]
0044B35AC  tbnz     w9, #0, #0x44b35bc
0044B35B0  mov      x0, x8
0044B35B4  bl       #0x3a7e60c ; 
0044B35B8  mov      x8, x0
0044B35BC  mov      x0, x8
0044B35C0  bl       #0x382bfa0 ; 
0044B35C4  ldr      x8, [x19, #0x38]
0044B35C8  mov      x1, x20
0044B35CC  mov      x2, x21
0044B35D0  mov      x3, x22
0044B35D4  ldr      x4, [x8, #0x20]
0044B35D8  mov      x19, x0
0044B35DC  bl       #0x5b062b8 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, char>$$.ctor
0044B35E0  mov      x0, x19
0044B35E4  ldp      x20, x19, [sp, #0x20]
0044B35E8  ldp      x22, x21, [sp, #0x10]
0044B35EC  ldp      x30, x23, [sp], #0x30
0044B35F0  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<int>
; RVA 0x44B35F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B35F4  stp      x30, x23, [sp, #-0x30]!
0044B35F8  stp      x22, x21, [sp, #0x10]
0044B35FC  stp      x20, x19, [sp, #0x20]
0044B3600  ldr      x8, [x2, #0x38]
0044B3604  mov      x19, x2
0044B3608  mov      x22, x1
0044B360C  mov      x23, x0
0044B3610  cbnz     x8, #0x44b3620
0044B3614  mov      x0, x19
0044B3618  bl       #0x3a7e668 ; 
0044B361C  ldr      x8, [x19, #0x38]
0044B3620  ldr      x0, [x23, #0x30]
0044B3624  ldr      x2, [x8, #8]
0044B3628  ldp      x20, x21, [x23, #0x20]
0044B362C  mov      x1, x22
0044B3630  bl       #0x45a1088 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, int>
0044B3634  ldr      x8, [x19, #0x38]
0044B3638  mov      x22, x0
0044B363C  ldr      x8, [x8, #0x18]
0044B3640  ldrb     w9, [x8, #0x135]
0044B3644  tbnz     w9, #0, #0x44b3654
0044B3648  mov      x0, x8
0044B364C  bl       #0x3a7e60c ; 
0044B3650  mov      x8, x0
0044B3654  mov      x0, x8
0044B3658  bl       #0x382bfa0 ; 
0044B365C  ldr      x8, [x19, #0x38]
0044B3660  mov      x1, x20
0044B3664  mov      x2, x21
0044B3668  mov      x3, x22
0044B366C  ldr      x4, [x8, #0x20]
0044B3670  mov      x19, x0
0044B3674  bl       #0x5b06568 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$.ctor
0044B3678  mov      x0, x19
0044B367C  ldp      x20, x19, [sp, #0x20]
0044B3680  ldp      x22, x21, [sp, #0x10]
0044B3684  ldp      x30, x23, [sp], #0x30
0044B3688  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<Int32Enum>
; RVA 0x44B368C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B368C  stp      x30, x23, [sp, #-0x30]!
0044B3690  stp      x22, x21, [sp, #0x10]
0044B3694  stp      x20, x19, [sp, #0x20]
0044B3698  ldr      x8, [x2, #0x38]
0044B369C  mov      x19, x2
0044B36A0  mov      x22, x1
0044B36A4  mov      x23, x0
0044B36A8  cbnz     x8, #0x44b36b8
0044B36AC  mov      x0, x19
0044B36B0  bl       #0x3a7e668 ; 
0044B36B4  ldr      x8, [x19, #0x38]
0044B36B8  ldr      x0, [x23, #0x30]
0044B36BC  ldr      x2, [x8, #8]
0044B36C0  ldp      x20, x21, [x23, #0x20]
0044B36C4  mov      x1, x22
0044B36C8  bl       #0x45a1144 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, Int32Enum>
0044B36CC  ldr      x8, [x19, #0x38]
0044B36D0  mov      x22, x0
0044B36D4  ldr      x8, [x8, #0x18]
0044B36D8  ldrb     w9, [x8, #0x135]
0044B36DC  tbnz     w9, #0, #0x44b36ec
0044B36E0  mov      x0, x8
0044B36E4  bl       #0x3a7e60c ; 
0044B36E8  mov      x8, x0
0044B36EC  mov      x0, x8
0044B36F0  bl       #0x382bfa0 ; 
0044B36F4  ldr      x8, [x19, #0x38]
0044B36F8  mov      x1, x20
0044B36FC  mov      x2, x21
0044B3700  mov      x3, x22
0044B3704  ldr      x4, [x8, #0x20]
0044B3708  mov      x19, x0
0044B370C  bl       #0x5b06818 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Int32Enum>$$.ctor
0044B3710  mov      x0, x19
0044B3714  ldp      x20, x19, [sp, #0x20]
0044B3718  ldp      x22, x21, [sp, #0x10]
0044B371C  ldp      x30, x23, [sp], #0x30
0044B3720  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<long>
; RVA 0x44B3724; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B3724  stp      x30, x23, [sp, #-0x30]!
0044B3728  stp      x22, x21, [sp, #0x10]
0044B372C  stp      x20, x19, [sp, #0x20]
0044B3730  ldr      x8, [x2, #0x38]
0044B3734  mov      x19, x2
0044B3738  mov      x22, x1
0044B373C  mov      x23, x0
0044B3740  cbnz     x8, #0x44b3750
0044B3744  mov      x0, x19
0044B3748  bl       #0x3a7e668 ; 
0044B374C  ldr      x8, [x19, #0x38]
0044B3750  ldr      x0, [x23, #0x30]
0044B3754  ldr      x2, [x8, #8]
0044B3758  ldp      x20, x21, [x23, #0x20]
0044B375C  mov      x1, x22
0044B3760  bl       #0x45a1200 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, long>
0044B3764  ldr      x8, [x19, #0x38]
0044B3768  mov      x22, x0
0044B376C  ldr      x8, [x8, #0x18]
0044B3770  ldrb     w9, [x8, #0x135]
0044B3774  tbnz     w9, #0, #0x44b3784
0044B3778  mov      x0, x8
0044B377C  bl       #0x3a7e60c ; 
0044B3780  mov      x8, x0
0044B3784  mov      x0, x8
0044B3788  bl       #0x382bfa0 ; 
0044B378C  ldr      x8, [x19, #0x38]
0044B3790  mov      x1, x20
0044B3794  mov      x2, x21
0044B3798  mov      x3, x22
0044B379C  ldr      x4, [x8, #0x20]
0044B37A0  mov      x19, x0
0044B37A4  bl       #0x5b06ac8 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, long>$$.ctor
0044B37A8  mov      x0, x19
0044B37AC  ldp      x20, x19, [sp, #0x20]
0044B37B0  ldp      x22, x21, [sp, #0x10]
0044B37B4  ldp      x30, x23, [sp], #0x30
0044B37B8  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<object>
; RVA 0x44B37BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B37BC  stp      x30, x23, [sp, #-0x30]!
0044B37C0  stp      x22, x21, [sp, #0x10]
0044B37C4  stp      x20, x19, [sp, #0x20]
0044B37C8  ldr      x8, [x2, #0x38]
0044B37CC  mov      x19, x2
0044B37D0  mov      x22, x1
0044B37D4  mov      x23, x0
0044B37D8  cbnz     x8, #0x44b37e8
0044B37DC  mov      x0, x19
0044B37E0  bl       #0x3a7e668 ; 
0044B37E4  ldr      x8, [x19, #0x38]
0044B37E8  ldr      x0, [x23, #0x30]
0044B37EC  ldr      x2, [x8, #8]
0044B37F0  ldp      x20, x21, [x23, #0x20]
0044B37F4  mov      x1, x22
0044B37F8  bl       #0x45a12bc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, object>
0044B37FC  ldr      x8, [x19, #0x38]
0044B3800  mov      x22, x0
0044B3804  ldr      x8, [x8, #0x18]
0044B3808  ldrb     w9, [x8, #0x135]
0044B380C  tbnz     w9, #0, #0x44b381c
0044B3810  mov      x0, x8
0044B3814  bl       #0x3a7e60c ; 
0044B3818  mov      x8, x0
0044B381C  mov      x0, x8
0044B3820  bl       #0x382bfa0 ; 
0044B3824  ldr      x8, [x19, #0x38]
0044B3828  mov      x1, x20
0044B382C  mov      x2, x21
0044B3830  mov      x3, x22
0044B3834  ldr      x4, [x8, #0x20]
0044B3838  mov      x19, x0
0044B383C  bl       #0x5b06d78 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$.ctor
0044B3840  mov      x0, x19
0044B3844  ldp      x20, x19, [sp, #0x20]
0044B3848  ldp      x22, x21, [sp, #0x10]
0044B384C  ldp      x30, x23, [sp], #0x30
0044B3850  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Select<Vector3>
; RVA 0x44B3854; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B3854  stp      x30, x23, [sp, #-0x30]!
0044B3858  stp      x22, x21, [sp, #0x10]
0044B385C  stp      x20, x19, [sp, #0x20]
0044B3860  ldr      x8, [x2, #0x38]
0044B3864  mov      x19, x2
0044B3868  mov      x22, x1
0044B386C  mov      x23, x0
0044B3870  cbnz     x8, #0x44b3880
0044B3874  mov      x0, x19
0044B3878  bl       #0x3a7e668 ; 
0044B387C  ldr      x8, [x19, #0x38]
0044B3880  ldr      x0, [x23, #0x30]
0044B3884  ldr      x2, [x8, #8]
0044B3888  ldp      x20, x21, [x23, #0x20]
0044B388C  mov      x1, x22
0044B3890  bl       #0x45a1378 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, Vector3>
0044B3894  ldr      x8, [x19, #0x38]
0044B3898  mov      x22, x0
0044B389C  ldr      x8, [x8, #0x18]
0044B38A0  ldrb     w9, [x8, #0x135]
0044B38A4  tbnz     w9, #0, #0x44b38b4
0044B38A8  mov      x0, x8
0044B38AC  bl       #0x3a7e60c ; 
0044B38B0  mov      x8, x0
0044B38B4  mov      x0, x8
0044B38B8  bl       #0x382bfa0 ; 
0044B38BC  ldr      x8, [x19, #0x38]
0044B38C0  mov      x1, x20
0044B38C4  mov      x2, x21
0044B38C8  mov      x3, x22
0044B38CC  ldr      x4, [x8, #0x20]
0044B38D0  mov      x19, x0
0044B38D4  bl       #0x5b07034 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Vector3>$$.ctor
0044B38D8  mov      x0, x19
0044B38DC  ldp      x20, x19, [sp, #0x20]
0044B38E0  ldp      x22, x21, [sp, #0x10]
0044B38E4  ldp      x30, x23, [sp], #0x30
0044B38E8  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$Where
; RVA 0x5B06FCC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06FCC  stp      x30, x21, [sp, #-0x20]!
005B06FD0  stp      x20, x19, [sp, #0x10]
005B06FD4  ldr      x8, [x2, #0x20]
005B06FD8  mov      x20, x2
005B06FDC  mov      x19, x1
005B06FE0  mov      x21, x0
005B06FE4  ldr      x8, [x8, #0xc0]
005B06FE8  ldr      x8, [x8, #0x98]
005B06FEC  ldrb     w9, [x8, #0x135]
005B06FF0  tbnz     w9, #0, #0x5b07000
005B06FF4  mov      x0, x8
005B06FF8  bl       #0x3a7e60c ; 
005B06FFC  mov      x8, x0
005B07000  mov      x0, x8
005B07004  bl       #0x382bfa0 ; 
005B07008  ldr      x8, [x20, #0x20]
005B0700C  mov      x1, x21
005B07010  mov      x2, x19
005B07014  mov      x20, x0
005B07018  ldr      x8, [x8, #0xc0]
005B0701C  ldr      x3, [x8, #0xa0]
005B07020  bl       #0x59caabc ; System.Linq.Enumerable.WhereEnumerableIterator<object>$$.ctor
005B07024  mov      x0, x20
005B07028  ldp      x20, x19, [sp, #0x10]
005B0702C  ldp      x30, x21, [sp], #0x20
005B07030  ret      

