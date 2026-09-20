; HotFix.BattleLogic.DankeSkillCreator$$LogError
; RVA 0x6860C34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006860C34  str      x30, [sp, #-0x30]!
006860C38  stp      x22, x21, [sp, #0x10]
006860C3C  stp      x20, x19, [sp, #0x20]
006860C40  adrp     x21, #0x959b000
006860C44  adrp     x22, #0x8f23000
006860C48  ldrb     w8, [x21, #0xa08]
006860C4C  ldr      x22, [x22, #0xc78] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.LogError() @ 0x9259db8
006860C50  mov      x19, x1
006860C54  mov      x20, x0
006860C58  tbnz     w8, #0, #0x6860c94
006860C5C  adrp     x0, #0x8f23000
006860C60  ldr      x0, [x0, #0xc78] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.LogError() @ 0x9259db8
006860C64  bl       #0x382bd14 ; 
006860C68  adrp     x0, #0x8ee1000
006860C6C  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006860C70  bl       #0x382bd14 ; 
006860C74  adrp     x0, #0x8f23000
006860C78  ldr      x0, [x0, #0xc80] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\DankeSkillCreator.cs @ 0x92f8028
006860C7C  bl       #0x382bd14 ; 
006860C80  adrp     x0, #0x8ee4000
006860C84  ldr      x0, [x0, #0x588] ; GLOBAL LogError @ 0x93048e0
006860C88  bl       #0x382bd14 ; 
006860C8C  mov      w8, #1
006860C90  strb     w8, [x21, #0xa08]
006860C94  ldr      x2, [x22]
006860C98  ldrb     w8, [x2, #0x53]
006860C9C  tbnz     w8, #5, #0x6860cf4
006860CA0  ldrb     w8, [x20, #0x90]
006860CA4  cbz      w8, #0x6860d10
006860CA8  adrp     x8, #0x8ee1000
006860CAC  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006860CB0  ldr      x0, [x8]
006860CB4  ldr      w8, [x0, #0xe0]
006860CB8  cbnz     w8, #0x6860cc0
006860CBC  bl       #0x382be8c ; 
006860CC0  adrp     x8, #0x8ee4000
006860CC4  adrp     x9, #0x8f23000
006860CC8  ldr      x8, [x8, #0x588] ; GLOBAL LogError @ 0x93048e0
006860CCC  ldr      x9, [x9, #0xc80] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\DankeSkillCreator.cs @ 0x92f8028
006860CD0  mov      x0, x19
006860CD4  ldp      x20, x19, [sp, #0x20]
006860CD8  ldr      x1, [x8]
006860CDC  ldr      x2, [x9]
006860CE0  ldp      x22, x21, [sp, #0x10]
006860CE4  mov      w3, #0x577
006860CE8  mov      x4, xzr
006860CEC  ldr      x30, [sp], #0x30
006860CF0  b        #0x7997754 ; Logger$$LogError
006860CF4  ldr      x3, [x2, #0x60]
006860CF8  mov      x0, x20
006860CFC  mov      x1, x19
006860D00  ldp      x20, x19, [sp, #0x20]
006860D04  ldp      x22, x21, [sp, #0x10]
006860D08  ldr      x30, [sp], #0x30
006860D0C  br       x3
006860D10  ldp      x20, x19, [sp, #0x20]
006860D14  ldp      x22, x21, [sp, #0x10]
006860D18  ldr      x30, [sp], #0x30
006860D1C  ret      

