; HotFix.BattleLogic.Weapon$$onCreateSalvoShape
; RVA 0x69F981C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069F981C  sub      sp, sp, #0x140
0069F9820  stp      x29, x30, [sp, #0xf0]
0069F9824  stp      x26, x25, [sp, #0x100]
0069F9828  stp      x24, x23, [sp, #0x110]
0069F982C  stp      x22, x21, [sp, #0x120]
0069F9830  stp      x20, x19, [sp, #0x130]
0069F9834  mrs      x25, tpidr_el0
0069F9838  ldr      x8, [x25, #0x28]
0069F983C  adrp     x24, #0x959d000
0069F9840  adrp     x26, #0x8f32000
0069F9844  mov      x19, x4
0069F9848  str      x8, [sp, #0xe8]
0069F984C  ldrb     w8, [x24, #0x46d]
0069F9850  ldr      x26, [x26, #0xf8] ; GLOBAL Method$HotFix.BattleLogic.Weapon.onCreateSalvoShape()
0069F9854  mov      x20, x3
0069F9858  mov      x23, x2
0069F985C  mov      x21, x1
0069F9860  mov      x22, x0
0069F9864  tbnz     w8, #0, #0x69f987c
0069F9868  adrp     x0, #0x8f32000
0069F986C  ldr      x0, [x0, #0xf8] ; GLOBAL Method$HotFix.BattleLogic.Weapon.onCreateSalvoShape()
0069F9870  bl       #0x382bd14 ; 
0069F9874  mov      w8, #1
0069F9878  strb     w8, [x24, #0x46d]
0069F987C  ldr      x24, [x26]
0069F9880  ldrb     w8, [x24, #0x53]
0069F9884  tbnz     w8, #5, #0x69f98b8
0069F9888  add      x0, sp, #8
0069F988C  mov      w2, #0x70
0069F9890  mov      x1, x23
0069F9894  bl       #0x89edad0 ; 
0069F9898  add      x2, sp, #8
0069F989C  mov      x0, x22
0069F98A0  mov      x1, x21
0069F98A4  mov      x3, x20
0069F98A8  mov      x4, x19
0069F98AC  mov      w5, wzr
0069F98B0  bl       #0x69f8e7c ; HotFix.BattleLogic.Weapon$$onCreateSpreadShape
0069F98B4  b        #0x69f98e8 ; 
0069F98B8  ldr      x26, [x24, #0x60]
0069F98BC  add      x0, sp, #0x78
0069F98C0  mov      w2, #0x70
0069F98C4  mov      x1, x23
0069F98C8  bl       #0x89edad0 ; 
0069F98CC  add      x2, sp, #0x78
0069F98D0  mov      x0, x22
0069F98D4  mov      x1, x21
0069F98D8  mov      x3, x20
0069F98DC  mov      x4, x19
0069F98E0  mov      x5, x24
0069F98E4  blr      x26
0069F98E8  ldr      x8, [x25, #0x28]
0069F98EC  ldr      x9, [sp, #0xe8]
0069F98F0  cmp      x8, x9
0069F98F4  b.ne     #0x69f9914
0069F98F8  ldp      x20, x19, [sp, #0x130]
0069F98FC  ldp      x22, x21, [sp, #0x120]
0069F9900  ldp      x24, x23, [sp, #0x110]
0069F9904  ldp      x26, x25, [sp, #0x100]
0069F9908  ldp      x29, x30, [sp, #0xf0]
0069F990C  add      sp, sp, #0x140
0069F9910  ret      
0069F9914  bl       #0x89edb60 ; 

