; HotFix.BattleLogic.AIMoveUpDown$$SetAIData
; RVA 0x656C790; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00656C790  str      x30, [sp, #-0x30]!
00656C794  stp      x22, x21, [sp, #0x10]
00656C798  stp      x20, x19, [sp, #0x20]
00656C79C  adrp     x21, #0x9599000
00656C7A0  adrp     x22, #0x8f06000
00656C7A4  ldrb     w8, [x21, #7]
00656C7A8  ldr      x22, [x22, #0xbe0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.SetAIData()
00656C7AC  mov      x19, x1
00656C7B0  mov      x20, x0
00656C7B4  tbnz     w8, #0, #0x656c7d8
00656C7B8  adrp     x0, #0x8f06000
00656C7BC  ldr      x0, [x0, #0xbe0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.SetAIData()
00656C7C0  bl       #0x382bd14 ; 
00656C7C4  adrp     x0, #0x8f06000
00656C7C8  ldr      x0, [x0, #0xbc0] ; GLOBAL HotFix.BattleLogic.AIMoveUpDown.Data_TypeInfo
00656C7CC  bl       #0x382bd14 ; 
00656C7D0  mov      w8, #1
00656C7D4  strb     w8, [x21, #7]
00656C7D8  ldr      x2, [x22]
00656C7DC  ldrb     w8, [x2, #0x53]
00656C7E0  tbnz     w8, #5, #0x656c848
00656C7E4  cbz      x19, #0x656c864
00656C7E8  adrp     x8, #0x8f06000
00656C7EC  ldr      x8, [x8, #0xbc0] ; GLOBAL HotFix.BattleLogic.AIMoveUpDown.Data_TypeInfo
00656C7F0  ldr      x9, [x19]
00656C7F4  ldr      x1, [x8]
00656C7F8  ldrb     w10, [x9, #0x130]
00656C7FC  ldrb     w8, [x1, #0x130]
00656C800  cmp      w10, w8
00656C804  b.lo     #0x656c888
00656C808  ldr      x10, [x9, #0xc8]
00656C80C  sub      x9, x8, #1
00656C810  ldr      x10, [x10, x9, lsl #3]
00656C814  cmp      x10, x1
00656C818  b.ne     #0x656c888
00656C81C  str      x19, [x20, #0x118]
00656C820  ldr      x10, [x19]
00656C824  ldrb     w11, [x10, #0x130]
00656C828  cmp      w11, w8
00656C82C  b.lo     #0x656c888
00656C830  ldr      x8, [x10, #0xc8]
00656C834  ldr      x8, [x8, x9, lsl #3]
00656C838  cmp      x8, x1
00656C83C  b.ne     #0x656c888
00656C840  add      x0, x20, #0x118
00656C844  b        #0x656c86c ; 
00656C848  ldr      x3, [x2, #0x60]
00656C84C  mov      x0, x20
00656C850  mov      x1, x19
00656C854  ldp      x20, x19, [sp, #0x20]
00656C858  ldp      x22, x21, [sp, #0x10]
00656C85C  ldr      x30, [sp], #0x30
00656C860  br       x3
00656C864  add      x0, x20, #0x118
00656C868  str      xzr, [x20, #0x118]
00656C86C  mov      x1, x19
00656C870  bl       #0x382bcb8 ; 
00656C874  mov      x0, x20
00656C878  ldp      x20, x19, [sp, #0x20]
00656C87C  ldp      x22, x21, [sp, #0x10]
00656C880  ldr      x30, [sp], #0x30
00656C884  b        #0x656c648 ; HotFix.BattleLogic.AIMoveUpDown$$onGetDataParams
00656C888  mov      x0, x19
00656C88C  bl       #0x382c354 ; 

