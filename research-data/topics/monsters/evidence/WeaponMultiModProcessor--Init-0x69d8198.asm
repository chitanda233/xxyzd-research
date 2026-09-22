; HotFix.BattleLogic.WeaponMultiModProcessor$$Init
; RVA 0x69D8198; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D8198  stp      x30, x21, [sp, #-0x20]!
0069D819C  stp      x20, x19, [sp, #0x10]
0069D81A0  adrp     x20, #0x959d000
0069D81A4  adrp     x21, #0x8f31000
0069D81A8  ldrb     w8, [x20, #0x380]
0069D81AC  ldr      x21, [x21, #0x3a0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.Init()
0069D81B0  mov      x19, x0
0069D81B4  tbnz     w8, #0, #0x69d81d8
0069D81B8  adrp     x0, #0x8f31000
0069D81BC  ldr      x0, [x0, #0x3a8] ; GLOBAL Method$HotFix.BattleLogic.ModProcessorBase<MultiModParams>.get_Params()
0069D81C0  bl       #0x382bd14 ; 
0069D81C4  adrp     x0, #0x8f31000
0069D81C8  ldr      x0, [x0, #0x3a0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.Init()
0069D81CC  bl       #0x382bd14 ; 
0069D81D0  mov      w8, #1
0069D81D4  strb     w8, [x20, #0x380]
0069D81D8  ldr      x1, [x21]
0069D81DC  ldrb     w8, [x1, #0x53]
0069D81E0  tbnz     w8, #5, #0x69d8204
0069D81E4  adrp     x20, #0x8f31000
0069D81E8  ldr      x20, [x20, #0x3a8] ; GLOBAL Method$HotFix.BattleLogic.ModProcessorBase<MultiModParams>.get_Params()
0069D81EC  ldr      x21, [x19, #0x50]
0069D81F0  ldr      x1, [x20]
0069D81F4  ldrb     w8, [x1, #0x53]
0069D81F8  tbnz     w8, #5, #0x69d8218
0069D81FC  ldr      x0, [x19, #0x30]
0069D8200  b        #0x69d8224 ; 
0069D8204  ldr      x2, [x1, #0x60]
0069D8208  mov      x0, x19
0069D820C  ldp      x20, x19, [sp, #0x10]
0069D8210  ldp      x30, x21, [sp], #0x20
0069D8214  br       x2
0069D8218  ldr      x8, [x1, #0x60]
0069D821C  mov      x0, x19
0069D8220  blr      x8
0069D8224  cbz      x0, #0x69d8310
0069D8228  ldr      x8, [x0, #0x18]
0069D822C  add      x8, x8, x21
0069D8230  str      x8, [x19, #0x50]
0069D8234  ldr      x1, [x20]
0069D8238  ldr      w21, [x19, #0x58]
0069D823C  ldrb     w8, [x1, #0x53]
0069D8240  tbnz     w8, #5, #0x69d824c
0069D8244  ldr      x0, [x19, #0x30]
0069D8248  b        #0x69d8258 ; 
0069D824C  ldr      x8, [x1, #0x60]
0069D8250  mov      x0, x19
0069D8254  blr      x8
0069D8258  cbz      x0, #0x69d8310
0069D825C  ldr      w8, [x0, #0x20]
0069D8260  add      w8, w8, w21
0069D8264  str      w8, [x19, #0x58]
0069D8268  ldr      x1, [x20]
0069D826C  ldr      x21, [x19, #0x60]
0069D8270  ldrb     w8, [x1, #0x53]
0069D8274  tbnz     w8, #5, #0x69d8280
0069D8278  ldr      x0, [x19, #0x30]
0069D827C  b        #0x69d828c ; 
0069D8280  ldr      x8, [x1, #0x60]
0069D8284  mov      x0, x19
0069D8288  blr      x8
0069D828C  cbz      x0, #0x69d8310
0069D8290  ldr      x8, [x0, #0x30]
0069D8294  add      x8, x8, x21
0069D8298  str      x8, [x19, #0x60]
0069D829C  ldr      x1, [x20]
0069D82A0  ldr      x21, [x19, #0x68]
0069D82A4  ldrb     w8, [x1, #0x53]
0069D82A8  tbnz     w8, #5, #0x69d82b4
0069D82AC  ldr      x0, [x19, #0x30]
0069D82B0  b        #0x69d82c0 ; 
0069D82B4  ldr      x8, [x1, #0x60]
0069D82B8  mov      x0, x19
0069D82BC  blr      x8
0069D82C0  cbz      x0, #0x69d8310
0069D82C4  ldr      x8, [x0, #0x38]
0069D82C8  add      x8, x8, x21
0069D82CC  str      x8, [x19, #0x68]
0069D82D0  ldr      x1, [x20]
0069D82D4  ldr      w20, [x19, #0x70]
0069D82D8  ldrb     w8, [x1, #0x53]
0069D82DC  tbnz     w8, #5, #0x69d82e8
0069D82E0  ldr      x0, [x19, #0x30]
0069D82E4  b        #0x69d82f4 ; 
0069D82E8  ldr      x8, [x1, #0x60]
0069D82EC  mov      x0, x19
0069D82F0  blr      x8
0069D82F4  cbz      x0, #0x69d8310
0069D82F8  ldr      w8, [x0, #0x40]
0069D82FC  add      w8, w8, w20
0069D8300  str      w8, [x19, #0x70]
0069D8304  ldp      x20, x19, [sp, #0x10]
0069D8308  ldp      x30, x21, [sp], #0x20
0069D830C  ret      
0069D8310  bl       #0x382bfb8 ; 

