; LocalModels.Bean.ChapterReward_MissionReward$$readImpl
; RVA 0x689C6A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689C6A8  stp      x30, x21, [sp, #-0x20]!
00689C6AC  stp      x20, x19, [sp, #0x10]
00689C6B0  adrp     x20, #0x959b000
00689C6B4  adrp     x21, #0x8f26000
00689C6B8  ldrb     w8, [x20, #0xe60]
00689C6BC  ldr      x21, [x21, #0x70]
00689C6C0  mov      x19, x0
00689C6C4  tbnz     w8, #0, #0x689c6dc
00689C6C8  adrp     x0, #0x8f26000
00689C6CC  ldr      x0, [x0, #0x70]
00689C6D0  bl       #0x382bd14 ; 
00689C6D4  mov      w8, #1
00689C6D8  strb     w8, [x20, #0xe60]
00689C6DC  ldr      x1, [x21]
00689C6E0  ldrb     w8, [x1, #0x53]
00689C6E4  tbnz     w8, #5, #0x689c734
00689C6E8  mov      x0, x19
00689C6EC  mov      x1, xzr
00689C6F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689C6F4  adrp     x21, #0x959c000
00689C6F8  ldrb     w8, [x21, #0x4e8]
00689C6FC  mov      w20, w0
00689C700  cbnz     w8, #0x689c718
00689C704  adrp     x0, #0x8f26000
00689C708  ldr      x0, [x0, #0x18]
00689C70C  bl       #0x382bd14 ; 
00689C710  mov      w8, #1
00689C714  strb     w8, [x21, #0x4e8]
00689C718  adrp     x8, #0x8f26000
00689C71C  ldr      x8, [x8, #0x18]
00689C720  ldr      x2, [x8]
00689C724  ldrb     w8, [x2, #0x53]
00689C728  tbnz     w8, #5, #0x689c748
00689C72C  str      w20, [x19, #0x20]
00689C730  b        #0x689c758 ; 
00689C734  ldr      x2, [x1, #0x60]
00689C738  mov      x0, x19
00689C73C  ldp      x20, x19, [sp, #0x10]
00689C740  ldp      x30, x21, [sp], #0x20
00689C744  br       x2
00689C748  ldr      x8, [x2, #0x60]
00689C74C  mov      x0, x19
00689C750  mov      w1, w20
00689C754  blr      x8
00689C758  mov      x0, x19
00689C75C  mov      x1, xzr
00689C760  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689C764  adrp     x21, #0x959c000
00689C768  ldrb     w8, [x21, #0x4e9]
00689C76C  mov      w20, w0
00689C770  cbnz     w8, #0x689c788
00689C774  adrp     x0, #0x8f26000
00689C778  ldr      x0, [x0, #0x28]
00689C77C  bl       #0x382bd14 ; 
00689C780  mov      w8, #1
00689C784  strb     w8, [x21, #0x4e9]
00689C788  adrp     x8, #0x8f26000
00689C78C  ldr      x8, [x8, #0x28]
00689C790  ldr      x2, [x8]
00689C794  ldrb     w8, [x2, #0x53]
00689C798  tbnz     w8, #5, #0x689c7a4
00689C79C  str      w20, [x19, #0x24]
00689C7A0  b        #0x689c7b4 ; 
00689C7A4  ldr      x8, [x2, #0x60]
00689C7A8  mov      x0, x19
00689C7AC  mov      w1, w20
00689C7B0  blr      x8
00689C7B4  mov      x0, x19
00689C7B8  mov      x1, xzr
00689C7BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689C7C0  adrp     x21, #0x959c000
00689C7C4  ldrb     w8, [x21, #0x4ea]
00689C7C8  mov      w20, w0
00689C7CC  cbnz     w8, #0x689c7e4
00689C7D0  adrp     x0, #0x8f26000
00689C7D4  ldr      x0, [x0, #0x38]
00689C7D8  bl       #0x382bd14 ; 
00689C7DC  mov      w8, #1
00689C7E0  strb     w8, [x21, #0x4ea]
00689C7E4  adrp     x8, #0x8f26000
00689C7E8  ldr      x8, [x8, #0x38]
00689C7EC  ldr      x2, [x8]
00689C7F0  ldrb     w8, [x2, #0x53]
00689C7F4  tbnz     w8, #5, #0x689c800
00689C7F8  str      w20, [x19, #0x28]
00689C7FC  b        #0x689c810 ; 
00689C800  ldr      x8, [x2, #0x60]
00689C804  mov      x0, x19
00689C808  mov      w1, w20
00689C80C  blr      x8
00689C810  mov      x0, x19
00689C814  mov      x1, xzr
00689C818  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
00689C81C  adrp     x21, #0x959c000
00689C820  ldrb     w8, [x21, #0x4eb]
00689C824  mov      x20, x0
00689C828  cbnz     w8, #0x689c840
00689C82C  adrp     x0, #0x8f26000
00689C830  ldr      x0, [x0, #0x48]
00689C834  bl       #0x382bd14 ; 
00689C838  mov      w8, #1
00689C83C  strb     w8, [x21, #0x4eb]
00689C840  adrp     x8, #0x8f26000
00689C844  ldr      x8, [x8, #0x48]
00689C848  ldr      x2, [x8]
00689C84C  ldrb     w8, [x2, #0x53]
00689C850  tbnz     w8, #5, #0x689c868
00689C854  mov      x0, x19
00689C858  str      x20, [x0, #0x30]!
00689C85C  mov      x1, x20
00689C860  bl       #0x382bcb8 ; 
00689C864  b        #0x689c878 ; 
00689C868  ldr      x8, [x2, #0x60]
00689C86C  mov      x0, x19
00689C870  mov      x1, x20
00689C874  blr      x8
00689C878  mov      x0, x19
00689C87C  mov      x1, xzr
00689C880  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689C884  adrp     x21, #0x959c000
00689C888  ldrb     w8, [x21, #0x4ec]
00689C88C  mov      w20, w0
00689C890  cbnz     w8, #0x689c8a8
00689C894  adrp     x0, #0x8f26000
00689C898  ldr      x0, [x0, #0x58]
00689C89C  bl       #0x382bd14 ; 
00689C8A0  mov      w8, #1
00689C8A4  strb     w8, [x21, #0x4ec]
00689C8A8  adrp     x8, #0x8f26000
00689C8AC  ldr      x8, [x8, #0x58]
00689C8B0  ldr      x2, [x8]
00689C8B4  ldrb     w8, [x2, #0x53]
00689C8B8  tbnz     w8, #5, #0x689c8c4
00689C8BC  str      w20, [x19, #0x38]
00689C8C0  b        #0x689c8d4 ; 
00689C8C4  ldr      x8, [x2, #0x60]
00689C8C8  mov      x0, x19
00689C8CC  mov      w1, w20
00689C8D0  blr      x8
00689C8D4  mov      x0, x19
00689C8D8  mov      x1, xzr
00689C8DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689C8E0  adrp     x21, #0x959c000
00689C8E4  ldrb     w8, [x21, #0x4ed]
00689C8E8  mov      w20, w0
00689C8EC  cbnz     w8, #0x689c904
00689C8F0  adrp     x0, #0x8f26000
00689C8F4  ldr      x0, [x0, #0x68]
00689C8F8  bl       #0x382bd14 ; 
00689C8FC  mov      w8, #1
00689C900  strb     w8, [x21, #0x4ed]
00689C904  adrp     x8, #0x8f26000
00689C908  ldr      x8, [x8, #0x68]
00689C90C  ldr      x2, [x8]
00689C910  ldrb     w8, [x2, #0x53]
00689C914  tbnz     w8, #5, #0x689c920
00689C918  str      w20, [x19, #0x3c]
00689C91C  b        #0x689c930 ; 
00689C920  ldr      x8, [x2, #0x60]
00689C924  mov      x0, x19
00689C928  mov      w1, w20
00689C92C  blr      x8
00689C930  ldp      x20, x19, [sp, #0x10]
00689C934  mov      w0, #1
00689C938  ldp      x30, x21, [sp], #0x20
00689C93C  ret      

