; HotFix.BattleLogic.MainDropManager$$OnDropItem
; RVA 0x6671B50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671B50  stp      x30, x25, [sp, #-0x40]!
006671B54  stp      x24, x23, [sp, #0x10]
006671B58  stp      x22, x21, [sp, #0x20]
006671B5C  stp      x20, x19, [sp, #0x30]
006671B60  adrp     x24, #0x9599000
006671B64  adrp     x25, #0x8f0f000
006671B68  ldrb     w8, [x24, #0xde5]
006671B6C  ldr      x25, [x25, #0x768] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.OnDropItem() @ 0x928dc10
006671B70  mov      x19, x4
006671B74  mov      x20, x3
006671B78  mov      x21, x2
006671B7C  mov      x22, x1
006671B80  mov      x23, x0
006671B84  tbnz     w8, #0, #0x6671b9c
006671B88  adrp     x0, #0x8f0f000
006671B8C  ldr      x0, [x0, #0x768] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.OnDropItem() @ 0x928dc10
006671B90  bl       #0x382bd14 ; 
006671B94  mov      w8, #1
006671B98  strb     w8, [x24, #0xde5]
006671B9C  ldr      x5, [x25]
006671BA0  ldrb     w8, [x5, #0x53]
006671BA4  tbnz     w8, #5, #0x6671bd8
006671BA8  mov      x0, x23
006671BAC  mov      x1, x22
006671BB0  mov      x2, x21
006671BB4  mov      x3, x20
006671BB8  mov      x4, x19
006671BBC  bl       #0x6671c2c ; HotFix.BattleLogic.MainDropManager$$CheckSpecialDrop
006671BC0  tbz      w0, #0, #0x6671c04
006671BC4  ldp      x20, x19, [sp, #0x30]
006671BC8  ldp      x22, x21, [sp, #0x20]
006671BCC  ldp      x24, x23, [sp, #0x10]
006671BD0  ldp      x30, x25, [sp], #0x40
006671BD4  ret      
006671BD8  ldr      x6, [x5, #0x60]
006671BDC  mov      x0, x23
006671BE0  mov      x1, x22
006671BE4  mov      x2, x21
006671BE8  mov      x3, x20
006671BEC  mov      x4, x19
006671BF0  ldp      x20, x19, [sp, #0x30]
006671BF4  ldp      x22, x21, [sp, #0x20]
006671BF8  ldp      x24, x23, [sp, #0x10]
006671BFC  ldp      x30, x25, [sp], #0x40
006671C00  br       x6
006671C04  mov      x0, x23
006671C08  mov      x1, x22
006671C0C  mov      x2, x21
006671C10  mov      x3, x20
006671C14  mov      x4, x19
006671C18  ldp      x20, x19, [sp, #0x30]
006671C1C  ldp      x22, x21, [sp, #0x20]
006671C20  ldp      x24, x23, [sp, #0x10]
006671C24  ldp      x30, x25, [sp], #0x40
006671C28  b        #0x6671cc8 ; HotFix.BattleLogic.MainDropManager$$AddDropItemFromGroup

