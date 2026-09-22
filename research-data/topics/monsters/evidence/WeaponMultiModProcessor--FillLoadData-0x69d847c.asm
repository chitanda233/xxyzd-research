; HotFix.BattleLogic.WeaponMultiModProcessor$$FillLoadData
; RVA 0x69D847C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D847C  stp      x30, x23, [sp, #-0x30]!
0069D8480  stp      x22, x21, [sp, #0x10]
0069D8484  stp      x20, x19, [sp, #0x20]
0069D8488  adrp     x21, #0x959d000
0069D848C  adrp     x22, #0x8f31000
0069D8490  ldrb     w8, [x21, #0x383]
0069D8494  ldr      x22, [x22, #0x3c0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.FillLoadData()
0069D8498  mov      x20, x1
0069D849C  mov      x19, x0
0069D84A0  tbnz     w8, #0, #0x69d850c
0069D84A4  adrp     x0, #0x8f10000
0069D84A8  ldr      x0, [x0, #0xe40] ; GLOBAL Method$System.Collections.Generic.List<FP>.Add()
0069D84AC  bl       #0x382bd14 ; 
0069D84B0  adrp     x0, #0x8f2e000
0069D84B4  ldr      x0, [x0, #0xc80] ; GLOBAL Method$System.Collections.Generic.List<FP>.Clear()
0069D84B8  bl       #0x382bd14 ; 
0069D84BC  adrp     x0, #0x8f10000
0069D84C0  ldr      x0, [x0, #0xe50] ; GLOBAL Method$System.Collections.Generic.List<FP>..ctor()
0069D84C4  bl       #0x382bd14 ; 
0069D84C8  adrp     x0, #0x8f2e000
0069D84CC  ldr      x0, [x0, #0xcc8] ; GLOBAL Method$System.Collections.Generic.List<FP>.get_Count()
0069D84D0  bl       #0x382bd14 ; 
0069D84D4  adrp     x0, #0x8f10000
0069D84D8  ldr      x0, [x0, #0xe58] ; GLOBAL System.Collections.Generic.List<FP>_TypeInfo
0069D84DC  bl       #0x382bd14 ; 
0069D84E0  adrp     x0, #0x8f31000
0069D84E4  ldr      x0, [x0, #0x3a8] ; GLOBAL Method$HotFix.BattleLogic.ModProcessorBase<MultiModParams>.get_Params()
0069D84E8  bl       #0x382bd14 ; 
0069D84EC  adrp     x0, #0x8f31000
0069D84F0  ldr      x0, [x0, #0x3c8] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<MultiModParams>.get_Weapon()
0069D84F4  bl       #0x382bd14 ; 
0069D84F8  adrp     x0, #0x8f31000
0069D84FC  ldr      x0, [x0, #0x3c0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.FillLoadData()
0069D8500  bl       #0x382bd14 ; 
0069D8504  mov      w8, #1
0069D8508  strb     w8, [x21, #0x383]
0069D850C  ldr      x2, [x22]
0069D8510  ldrb     w8, [x2, #0x53]
0069D8514  tbnz     w8, #5, #0x69d8560
0069D8518  ldr      w8, [x19, #0x70]
0069D851C  cmp      w8, #1
0069D8520  b.lt     #0x69d85a8
0069D8524  adrp     x21, #0x9591000
0069D8528  ldrb     w8, [x21, #0xa4b]
0069D852C  cbnz     w8, #0x69d8544
0069D8530  adrp     x0, #0x8ee5000
0069D8534  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069D8538  bl       #0x382bd14 ; 
0069D853C  mov      w8, #1
0069D8540  strb     w8, [x21, #0xa4b]
0069D8544  adrp     x8, #0x8ee5000
0069D8548  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069D854C  ldr      x1, [x8]
0069D8550  ldrb     w8, [x1, #0x53]
0069D8554  tbnz     w8, #5, #0x69d857c
0069D8558  ldr      x0, [x19, #0x20]
0069D855C  b        #0x69d8588 ; 
0069D8560  ldr      x3, [x2, #0x60]
0069D8564  mov      x0, x19
0069D8568  mov      x1, x20
0069D856C  ldp      x20, x19, [sp, #0x20]
0069D8570  ldp      x22, x21, [sp, #0x10]
0069D8574  ldp      x30, x23, [sp], #0x30
0069D8578  br       x3
0069D857C  ldr      x8, [x1, #0x60]
0069D8580  mov      x0, x19
0069D8584  blr      x8
0069D8588  cbz      x0, #0x69d8868
0069D858C  mov      w2, #0x64
0069D8590  mov      w1, wzr
0069D8594  mov      x3, xzr
0069D8598  bl       #0x54b65d8 ; 
0069D859C  ldr      w8, [x19, #0x70]
0069D85A0  cmp      w0, w8
0069D85A4  b.gt     #0x69d87a4
0069D85A8  ldr      x21, [x20, #0x190]
0069D85AC  cbnz     x21, #0x69d861c
0069D85B0  mov      x22, x19
0069D85B4  ldr      x1, [x22, #0x48]!
0069D85B8  add      x21, x20, #0x190
0069D85BC  cbz      x1, #0x69d85d0
0069D85C0  ldr      w8, [x1, #0x1c]
0069D85C4  add      w8, w8, #1
0069D85C8  stp      wzr, w8, [x1, #0x18]
0069D85CC  b        #0x69d8608 ; 
0069D85D0  adrp     x8, #0x8f10000
0069D85D4  ldr      x8, [x8, #0xe58] ; GLOBAL System.Collections.Generic.List<FP>_TypeInfo
0069D85D8  ldr      x0, [x8]
0069D85DC  bl       #0x382bfa0 ; 
0069D85E0  adrp     x8, #0x8f10000
0069D85E4  ldr      x8, [x8, #0xe50] ; GLOBAL Method$System.Collections.Generic.List<FP>..ctor()
0069D85E8  mov      x23, x0
0069D85EC  ldr      x1, [x8]
0069D85F0  bl       #0x4d37500 ; System.Collections.Generic.List<FP>$$.ctor
0069D85F4  mov      x0, x22
0069D85F8  mov      x1, x23
0069D85FC  str      x23, [x22]
0069D8600  bl       #0x382bcb8 ; 
0069D8604  ldr      x1, [x22]
0069D8608  mov      x0, x21
0069D860C  str      x1, [x21]
0069D8610  bl       #0x382bcb8 ; 
0069D8614  ldr      x21, [x21]
0069D8618  cbz      x21, #0x69d8868
0069D861C  ldr      w8, [x21, #0x18]
0069D8620  cbz      w8, #0x69d87d4
0069D8624  ldr      w8, [x19, #0x58]
0069D8628  cmp      w8, #1
0069D862C  b.lt     #0x69d86a0
0069D8630  adrp     x23, #0x8f10000
0069D8634  ldr      x23, [x23, #0xe40] ; GLOBAL Method$System.Collections.Generic.List<FP>.Add()
0069D8638  mov      w22, wzr
0069D863C  ldr      w10, [x21, #0x1c]
0069D8640  ldr      x1, [x19, #0x60]
0069D8644  ldr      x8, [x21, #0x10]
0069D8648  ldr      x9, [x23]
0069D864C  add      w10, w10, #1
0069D8650  str      w10, [x21, #0x1c]
0069D8654  cbz      x8, #0x69d8868
0069D8658  ldrsw    x10, [x21, #0x18]
0069D865C  ldr      w11, [x8, #0x18]
0069D8660  cmp      w10, w11
0069D8664  b.hs     #0x69d867c
0069D8668  add      w9, w10, #1
0069D866C  add      x8, x8, x10, lsl #3
0069D8670  str      w9, [x21, #0x18]
0069D8674  str      x1, [x8, #0x20]
0069D8678  b        #0x69d8690 ; 
0069D867C  ldr      x8, [x9, #0x20]
0069D8680  mov      x0, x21
0069D8684  ldr      x8, [x8, #0xc0]
0069D8688  ldr      x2, [x8, #0x70]
0069D868C  bl       #0x4d37d54 ; System.Collections.Generic.List<FP>$$AddWithResize
0069D8690  ldr      w8, [x19, #0x58]
0069D8694  add      w22, w22, #1
0069D8698  cmp      w22, w8
0069D869C  b.lt     #0x69d863c
0069D86A0  ldr      x8, [x20, #8]
0069D86A4  ldr      x9, [x19, #0x50]
0069D86A8  ldr      w10, [x20, #0x10]
0069D86AC  adrp     x21, #0x8f31000
0069D86B0  add      x8, x9, x8
0069D86B4  str      x8, [x20, #8]
0069D86B8  ldr      w8, [x19, #0x58]
0069D86BC  add      w8, w8, w10
0069D86C0  str      w8, [x20, #0x10]
0069D86C4  ldr      x21, [x21, #0x3a8] ; GLOBAL Method$HotFix.BattleLogic.ModProcessorBase<MultiModParams>.get_Params()
0069D86C8  ldr      x1, [x21]
0069D86CC  ldrb     w8, [x1, #0x53]
0069D86D0  tbnz     w8, #5, #0x69d86dc
0069D86D4  ldr      x0, [x19, #0x30]
0069D86D8  b        #0x69d86e8 ; 
0069D86DC  ldr      x8, [x1, #0x60]
0069D86E0  mov      x0, x19
0069D86E4  blr      x8
0069D86E8  cbz      x0, #0x69d8868
0069D86EC  ldr      x1, [x0, #0x28]
0069D86F0  mov      x0, x20
0069D86F4  mov      x2, xzr
0069D86F8  bl       #0x6a2598c ; HotFix.BattleLogic.Weapon.WeaponFireInfo$$SetFireInterval
0069D86FC  ldr      x8, [x20, #0x1a8]
0069D8700  ldr      x9, [x19, #0x68]
0069D8704  add      x8, x9, x8
0069D8708  str      x8, [x20, #0x1a8]
0069D870C  adrp     x8, #0x8f31000
0069D8710  ldr      x8, [x8, #0x3c8] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<MultiModParams>.get_Weapon()
0069D8714  ldr      x1, [x8]
0069D8718  ldrb     w8, [x1, #0x53]
0069D871C  tbnz     w8, #5, #0x69d8728
0069D8720  ldr      x20, [x19, #0x40]
0069D8724  b        #0x69d8738 ; 
0069D8728  ldr      x8, [x1, #0x60]
0069D872C  mov      x0, x19
0069D8730  blr      x8
0069D8734  mov      x20, x0
0069D8738  ldr      x1, [x21]
0069D873C  ldrb     w8, [x1, #0x53]
0069D8740  tbnz     w8, #5, #0x69d874c
0069D8744  ldr      x0, [x19, #0x30]
0069D8748  b        #0x69d8758 ; 
0069D874C  ldr      x8, [x1, #0x60]
0069D8750  mov      x0, x19
0069D8754  blr      x8
0069D8758  cbz      x0, #0x69d8868
0069D875C  cbz      x20, #0x69d8868
0069D8760  ldr      w19, [x0, #0x44]
0069D8764  adrp     x22, #0x959d000
0069D8768  ldrb     w8, [x22, #0x484]
0069D876C  cmp      w19, #0
0069D8770  cset     w21, eq
0069D8774  cbnz     w8, #0x69d878c
0069D8778  adrp     x0, #0x8f30000
0069D877C  ldr      x0, [x0, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.Weapon.set_CanSwitchFireholdTarget()
0069D8780  bl       #0x382bd14 ; 
0069D8784  mov      w8, #1
0069D8788  strb     w8, [x22, #0x484]
0069D878C  adrp     x8, #0x8f30000
0069D8790  ldr      x8, [x8, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.Weapon.set_CanSwitchFireholdTarget()
0069D8794  ldr      x2, [x8]
0069D8798  ldrb     w8, [x2, #0x53]
0069D879C  tbnz     w8, #5, #0x69d87b4
0069D87A0  strb     w21, [x20, #0x28]
0069D87A4  ldp      x20, x19, [sp, #0x20]
0069D87A8  ldp      x22, x21, [sp, #0x10]
0069D87AC  ldp      x30, x23, [sp], #0x30
0069D87B0  ret      
0069D87B4  ldr      x3, [x2, #0x60]
0069D87B8  cmp      w19, #0
0069D87BC  mov      x0, x20
0069D87C0  ldp      x20, x19, [sp, #0x20]
0069D87C4  ldp      x22, x21, [sp, #0x10]
0069D87C8  cset     w1, eq
0069D87CC  ldp      x30, x23, [sp], #0x30
0069D87D0  br       x3
0069D87D4  ldr      w8, [x20, #0x10]
0069D87D8  cmp      w8, #1
0069D87DC  b.lt     #0x69d8624
0069D87E0  adrp     x22, #0x8f10000
0069D87E4  ldr      x22, [x22, #0xe40] ; GLOBAL Method$System.Collections.Generic.List<FP>.Add()
0069D87E8  ldr      w10, [x21, #0x1c]
0069D87EC  ldr      x8, [x21, #0x10]
0069D87F0  ldr      x9, [x22]
0069D87F4  add      w10, w10, #1
0069D87F8  str      w10, [x21, #0x1c]
0069D87FC  cbz      x8, #0x69d8868
0069D8800  mov      w23, wzr
0069D8804  mov      w10, wzr
0069D8808  ldr      w11, [x8, #0x18]
0069D880C  cmp      w10, w11
0069D8810  b.hs     #0x69d8828
0069D8814  add      w9, w10, #1
0069D8818  add      x8, x8, w10, sxtw #3
0069D881C  str      w9, [x21, #0x18]
0069D8820  str      xzr, [x8, #0x20]
0069D8824  b        #0x69d8840 ; 
0069D8828  ldr      x8, [x9, #0x20]
0069D882C  mov      x0, x21
0069D8830  mov      x1, xzr
0069D8834  ldr      x8, [x8, #0xc0]
0069D8838  ldr      x2, [x8, #0x70]
0069D883C  bl       #0x4d37d54 ; System.Collections.Generic.List<FP>$$AddWithResize
0069D8840  ldr      w8, [x20, #0x10]
0069D8844  add      w23, w23, #1
0069D8848  cmp      w23, w8
0069D884C  b.ge     #0x69d8624
0069D8850  ldp      w10, w11, [x21, #0x18]
0069D8854  ldr      x8, [x21, #0x10]
0069D8858  ldr      x9, [x22]
0069D885C  add      w11, w11, #1
0069D8860  str      w11, [x21, #0x1c]
0069D8864  cbnz     x8, #0x69d8808
0069D8868  bl       #0x382bfb8 ; 

