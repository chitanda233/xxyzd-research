; HotFix.BattleLogic.SinglePlayerSkillCreator$$.ctor
; RVA 0x685CB68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685CB68  str      x30, [sp, #-0x30]!
00685CB6C  stp      x22, x21, [sp, #0x10]
00685CB70  stp      x20, x19, [sp, #0x20]
00685CB74  adrp     x20, #0x959b000
00685CB78  adrp     x21, #0x8f23000
00685CB7C  ldrb     w8, [x20, #0xab5]
00685CB80  ldr      x21, [x21, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator..ctor() @ 0x92aa960
00685CB84  mov      x19, x0
00685CB88  tbnz     w8, #0, #0x685cbd0
00685CB8C  adrp     x0, #0x8ec2000
00685CB90  ldr      x0, [x0, #0x2b8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de20
00685CB94  bl       #0x382bd14 ; 
00685CB98  adrp     x0, #0x8f23000
00685CB9C  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>..ctor() @ 0x921eb90
00685CBA0  bl       #0x382bd14 ; 
00685CBA4  adrp     x0, #0x8ec2000
00685CBA8  ldr      x0, [x0, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
00685CBAC  bl       #0x382bd14 ; 
00685CBB0  adrp     x0, #0x8f23000
00685CBB4  ldr      x0, [x0, #0xaf8] ; GLOBAL System.Collections.Generic.List<NewPlayerBoostRecord>_TypeInfo @ 0x91da2f0
00685CBB8  bl       #0x382bd14 ; 
00685CBBC  adrp     x0, #0x8f23000
00685CBC0  ldr      x0, [x0, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator..ctor() @ 0x92aa960
00685CBC4  bl       #0x382bd14 ; 
00685CBC8  mov      w8, #1
00685CBCC  strb     w8, [x20, #0xab5]
00685CBD0  ldr      x1, [x21]
00685CBD4  ldrb     w8, [x1, #0x53]
00685CBD8  tbnz     w8, #5, #0x685cc58
00685CBDC  adrp     x8, #0x8ec2000
00685CBE0  ldr      x8, [x8, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
00685CBE4  adrp     x20, #0x8ec2000
00685CBE8  adrp     x21, #0x8f23000
00685CBEC  adrp     x22, #0x8f23000
00685CBF0  ldr      x0, [x8]
00685CBF4  ldr      x20, [x20, #0x2b8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de20
00685CBF8  ldr      x21, [x21, #0xaf8] ; GLOBAL System.Collections.Generic.List<NewPlayerBoostRecord>_TypeInfo @ 0x91da2f0
00685CBFC  ldr      x22, [x22, #0xaf0] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>..ctor() @ 0x921eb90
00685CC00  bl       #0x382bfa0 ; 
00685CC04  ldr      x1, [x20]
00685CC08  mov      x20, x0
00685CC0C  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
00685CC10  mov      x0, x19
00685CC14  str      x20, [x0, #0x68]!
00685CC18  mov      x1, x20
00685CC1C  bl       #0x382bcb8 ; 
00685CC20  ldr      x0, [x21]
00685CC24  bl       #0x382bfa0 ; 
00685CC28  ldr      x1, [x22]
00685CC2C  mov      x20, x0
00685CC30  bl       #0x4dac814 ; System.Collections.Generic.List<NewPlayerBoostRecord>$$.ctor
00685CC34  mov      x0, x19
00685CC38  str      x20, [x0, #0x70]!
00685CC3C  mov      x1, x20
00685CC40  bl       #0x382bcb8 ; 
00685CC44  mov      x0, x19
00685CC48  ldp      x20, x19, [sp, #0x20]
00685CC4C  ldp      x22, x21, [sp, #0x10]
00685CC50  ldr      x30, [sp], #0x30
00685CC54  b        #0x685c358 ; HotFix.BattleLogic.HeroSkillCreator$$.ctor
00685CC58  ldr      x2, [x1, #0x60]
00685CC5C  mov      x0, x19
00685CC60  ldp      x20, x19, [sp, #0x20]
00685CC64  ldp      x22, x21, [sp, #0x10]
00685CC68  ldr      x30, [sp], #0x30
00685CC6C  br       x2

