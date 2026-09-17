; System.Collections.Generic.Comparer<WeightRandomData>$$get_Default
; RVA 0x5C4F3CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C4F3CC  str      x30, [sp, #-0x20]!
005C4F3D0  stp      x20, x19, [sp, #0x10]
005C4F3D4  mov      x19, x0
005C4F3D8  ldr      x0, [x0, #0x20]
005C4F3DC  ldrb     w8, [x0, #0x135]
005C4F3E0  tbnz     w8, #0, #0x5c4f3e8
005C4F3E4  bl       #0x3a7e60c ; 
005C4F3E8  ldr      x8, [x0, #0xc0]
005C4F3EC  ldr      x0, [x8, #0x10]
005C4F3F0  ldrb     w8, [x0, #0x135]
005C4F3F4  tbnz     w8, #0, #0x5c4f3fc
005C4F3F8  bl       #0x3a7e60c ; 
005C4F3FC  ldr      x8, [x0, #0xb8]
005C4F400  ldr      x20, [x8]
005C4F404  bl       #0x382bdb0 ; 
005C4F408  cbnz     x20, #0x5c4f48c
005C4F40C  ldr      x0, [x19, #0x20]
005C4F410  ldrb     w8, [x0, #0x135]
005C4F414  tbnz     w8, #0, #0x5c4f41c
005C4F418  bl       #0x3a7e60c ; 
005C4F41C  ldr      x8, [x0, #0xc0]
005C4F420  ldr      x0, [x8, #0x18]
005C4F424  bl       #0x5c4f49c ; System.Collections.Generic.Comparer<WeightRandomData>$$CreateComparer
005C4F428  mov      x20, x0
005C4F42C  bl       #0x382bdb0 ; 
005C4F430  ldr      x0, [x19, #0x20]
005C4F434  ldrb     w8, [x0, #0x135]
005C4F438  tbnz     w8, #0, #0x5c4f440
005C4F43C  bl       #0x3a7e60c ; 
005C4F440  ldr      x8, [x0, #0xc0]
005C4F444  ldr      x0, [x8, #0x10]
005C4F448  ldrb     w8, [x0, #0x135]
005C4F44C  tbnz     w8, #0, #0x5c4f454
005C4F450  bl       #0x3a7e60c ; 
005C4F454  ldr      x8, [x0, #0xb8]
005C4F458  str      x20, [x8]
005C4F45C  ldr      x0, [x19, #0x20]
005C4F460  ldrb     w8, [x0, #0x135]
005C4F464  tbnz     w8, #0, #0x5c4f46c
005C4F468  bl       #0x3a7e60c ; 
005C4F46C  ldr      x8, [x0, #0xc0]
005C4F470  ldr      x0, [x8, #0x10]
005C4F474  ldrb     w8, [x0, #0x135]
005C4F478  tbnz     w8, #0, #0x5c4f480
005C4F47C  bl       #0x3a7e60c ; 
005C4F480  ldr      x0, [x0, #0xb8]
005C4F484  mov      x1, x20
005C4F488  bl       #0x382bcb8 ; 
005C4F48C  mov      x0, x20
005C4F490  ldp      x20, x19, [sp, #0x10]
005C4F494  ldr      x30, [sp], #0x20
005C4F498  ret      

; System.Collections.Generic.Comparer<WeightRandomData>$$CreateComparer
; RVA 0x5C4F49C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C4F49C  str      x30, [sp, #-0x40]!
005C4F4A0  stp      x24, x23, [sp, #0x10]
005C4F4A4  stp      x22, x21, [sp, #0x20]
005C4F4A8  stp      x20, x19, [sp, #0x30]
005C4F4AC  adrp     x20, #0x9595000
005C4F4B0  ldrb     w8, [x20, #0x908]
005C4F4B4  mov      x19, x0
005C4F4B8  tbnz     w8, #0, #0x5c4f518
005C4F4BC  adrp     x0, #0x8eeb000
005C4F4C0  ldr      x0, [x0, #0x138]
005C4F4C4  bl       #0x382bd14 ; 
005C4F4C8  adrp     x0, #0x8eeb000
005C4F4CC  ldr      x0, [x0, #0x140]
005C4F4D0  bl       #0x382bd14 ; 
005C4F4D4  adrp     x0, #0x8eeb000
005C4F4D8  ldr      x0, [x0, #0x148]
005C4F4DC  bl       #0x382bd14 ; 
005C4F4E0  adrp     x0, #0x8ee8000
005C4F4E4  ldr      x0, [x0, #0xe28]
005C4F4E8  bl       #0x382bd14 ; 
005C4F4EC  adrp     x0, #0x8ee5000
005C4F4F0  ldr      x0, [x0, #0xd70]
005C4F4F4  bl       #0x382bd14 ; 
005C4F4F8  adrp     x0, #0x8ebf000
005C4F4FC  ldr      x0, [x0, #0xd08]
005C4F500  bl       #0x382bd14 ; 
005C4F504  adrp     x0, #0x8ebf000
005C4F508  ldr      x0, [x0, #0x3a8]
005C4F50C  bl       #0x382bd14 ; 
005C4F510  mov      w8, #1
005C4F514  strb     w8, [x20, #0x908]
005C4F518  ldr      x0, [x19, #0x20]
005C4F51C  adrp     x24, #0x8ebf000
005C4F520  ldrb     w8, [x0, #0x135]
005C4F524  ldr      x24, [x24, #0x3a8]
005C4F528  tbnz     w8, #0, #0x5c4f530
005C4F52C  bl       #0x3a7e60c ; 
005C4F530  ldr      x8, [x24]
005C4F534  ldr      x9, [x0, #0xc0]
005C4F538  ldr      w10, [x8, #0xe0]
005C4F53C  ldr      x20, [x9, #0x20]
005C4F540  cbnz     w10, #0x5c4f54c
005C4F544  mov      x0, x8
005C4F548  bl       #0x382be8c ; 
005C4F54C  adrp     x23, #0x8ee5000
005C4F550  ldr      x23, [x23, #0xd70]
005C4F554  mov      x0, x20
005C4F558  mov      x1, xzr
005C4F55C  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
005C4F560  mov      x20, x0
005C4F564  cbz      x0, #0x5c4f594
005C4F568  ldr      x8, [x20]
005C4F56C  ldr      x1, [x23]
005C4F570  ldrb     w10, [x8, #0x130]
005C4F574  ldrb     w9, [x1, #0x130]
005C4F578  cmp      w10, w9
005C4F57C  b.lo     #0x5c4f888
005C4F580  ldr      x8, [x8, #0xc8]
005C4F584  add      x8, x8, x9, lsl #3
005C4F588  ldur     x8, [x8, #-8]
005C4F58C  cmp      x8, x1
005C4F590  b.ne     #0x5c4f888
005C4F594  ldr      x0, [x19, #0x20]
005C4F598  ldrb     w8, [x0, #0x135]
005C4F59C  tbnz     w8, #0, #0x5c4f5a4
005C4F5A0  bl       #0x3a7e60c ; 
005C4F5A4  ldr      x8, [x0, #0xc0]
005C4F5A8  mov      x1, xzr
005C4F5AC  ldr      x0, [x8, #0x28]
005C4F5B0  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
005C4F5B4  cbz      x0, #0x5c4f884
005C4F5B8  ldr      x8, [x0]
005C4F5BC  mov      x1, x20
005C4F5C0  ldr      x9, [x8, #0x388]
005C4F5C4  ldr      x2, [x8, #0x390]
005C4F5C8  blr      x9
005C4F5CC  tbz      w0, #0, #0x5c4f68c
005C4F5D0  adrp     x8, #0x8eeb000
005C4F5D4  ldr      x0, [x24]
005C4F5D8  ldr      x8, [x8, #0x138]
005C4F5DC  ldr      w9, [x0, #0xe0]
005C4F5E0  ldr      x21, [x8]
005C4F5E4  cbnz     w9, #0x5c4f5ec
005C4F5E8  bl       #0x382be8c ; 
005C4F5EC  mov      x0, x21
005C4F5F0  mov      x1, xzr
005C4F5F4  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
005C4F5F8  ldr      x8, [x23]
005C4F5FC  mov      x21, x0
005C4F600  ldr      w9, [x8, #0xe0]
005C4F604  cbnz     w9, #0x5c4f610
005C4F608  mov      x0, x8
005C4F60C  bl       #0x382be8c ; 
005C4F610  mov      x0, x21
005C4F614  mov      x1, x20
005C4F618  mov      x2, xzr
005C4F61C  bl       #0x7c21f30 ; System.RuntimeType$$CreateInstanceForAnotherGenericParameter
005C4F620  ldr      x8, [x19, #0x20]
005C4F624  mov      x19, x0
005C4F628  ldrb     w9, [x8, #0x135]
005C4F62C  tbnz     w9, #0, #0x5c4f63c
005C4F630  mov      x0, x8
005C4F634  bl       #0x3a7e60c ; 
005C4F638  mov      x8, x0
005C4F63C  ldr      x8, [x8, #0xc0]
005C4F640  ldr      x1, [x8]
005C4F644  ldrb     w8, [x1, #0x135]
005C4F648  tbnz     w8, #0, #0x5c4f658
005C4F64C  mov      x0, x1
005C4F650  bl       #0x3a7e60c ; 
005C4F654  mov      x1, x0
005C4F658  cbz      x19, #0x5c4f86c
005C4F65C  ldr      x8, [x19]
005C4F660  ldrb     w9, [x1, #0x130]
005C4F664  ldrb     w10, [x8, #0x130]
005C4F668  cmp      w10, w9
005C4F66C  b.lo     #0x5c4f684
005C4F670  ldr      x8, [x8, #0xc8]
005C4F674  add      x8, x8, x9, lsl #3
005C4F678  ldur     x8, [x8, #-8]
005C4F67C  cmp      x8, x1
005C4F680  b.eq     #0x5c4f86c
005C4F684  mov      x0, x19
005C4F688  bl       #0x382c354 ; 
005C4F68C  cbz      x20, #0x5c4f884
005C4F690  ldr      x8, [x20]
005C4F694  mov      x0, x20
005C4F698  ldr      x9, [x8, #0x4c8]
005C4F69C  ldr      x1, [x8, #0x4d0]
005C4F6A0  blr      x9
005C4F6A4  tbz      w0, #0, #0x5c4f818
005C4F6A8  ldr      x8, [x20]
005C4F6AC  mov      x0, x20
005C4F6B0  ldr      x9, [x8, #0x558]
005C4F6B4  ldr      x1, [x8, #0x560]
005C4F6B8  blr      x9
005C4F6BC  adrp     x9, #0x8ee8000
005C4F6C0  ldr      x8, [x24]
005C4F6C4  ldr      x9, [x9, #0xe28]
005C4F6C8  mov      x21, x0
005C4F6CC  ldr      w10, [x8, #0xe0]
005C4F6D0  ldr      x22, [x9]
005C4F6D4  cbnz     w10, #0x5c4f6e0
005C4F6D8  mov      x0, x8
005C4F6DC  bl       #0x382be8c ; 
005C4F6E0  mov      x0, x22
005C4F6E4  mov      x1, xzr
005C4F6E8  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
005C4F6EC  mov      x1, x0
005C4F6F0  mov      x0, x21
005C4F6F4  mov      x2, xzr
005C4F6F8  bl       #0x7bf2990 ; System.Type$$op_Equality
005C4F6FC  tbz      w0, #0, #0x5c4f818
005C4F700  ldr      x8, [x20]
005C4F704  mov      x0, x20
005C4F708  ldr      x9, [x8, #0x578]
005C4F70C  ldr      x1, [x8, #0x580]
005C4F710  blr      x9
005C4F714  cbz      x0, #0x5c4f884
005C4F718  ldr      w8, [x0, #0x18]
005C4F71C  cbz      w8, #0x5c4f890
005C4F720  ldr      x20, [x0, #0x20]
005C4F724  cbz      x20, #0x5c4f754
005C4F728  ldr      x8, [x20]
005C4F72C  ldr      x1, [x23]
005C4F730  ldrb     w10, [x8, #0x130]
005C4F734  ldrb     w9, [x1, #0x130]
005C4F738  cmp      w10, w9
005C4F73C  b.lo     #0x5c4f888
005C4F740  ldr      x8, [x8, #0xc8]
005C4F744  add      x8, x8, x9, lsl #3
005C4F748  ldur     x8, [x8, #-8]
005C4F74C  cmp      x8, x1
005C4F750  b.ne     #0x5c4f888
005C4F754  adrp     x8, #0x8eeb000
005C4F758  ldr      x0, [x24]
005C4F75C  ldr      x8, [x8, #0x140]
005C4F760  ldr      w9, [x0, #0xe0]
005C4F764  ldr      x21, [x8]
005C4F768  cbnz     w9, #0x5c4f770
005C4F76C  bl       #0x382be8c ; 
005C4F770  mov      x0, x21
005C4F774  mov      x1, xzr
005C4F778  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
005C4F77C  adrp     x8, #0x8ebf000
005C4F780  ldr      x8, [x8, #0xd08]
005C4F784  mov      x21, x0
005C4F788  mov      w1, #1
005C4F78C  ldr      x8, [x8]
005C4F790  mov      x0, x8
005C4F794  bl       #0x382bdfc ; 
005C4F798  cbz      x0, #0x5c4f884
005C4F79C  mov      x22, x0
005C4F7A0  cbz      x20, #0x5c4f7b8
005C4F7A4  ldr      x8, [x22]
005C4F7A8  mov      x0, x20
005C4F7AC  ldr      x1, [x8, #0x40]
005C4F7B0  bl       #0x382be90 ; 
005C4F7B4  cbz      x0, #0x5c4f894
005C4F7B8  ldr      w8, [x22, #0x18]
005C4F7BC  cbz      w8, #0x5c4f890
005C4F7C0  mov      x0, x22
005C4F7C4  str      x20, [x0, #0x20]!
005C4F7C8  mov      x1, x20
005C4F7CC  bl       #0x382bcb8 ; 
005C4F7D0  cbz      x21, #0x5c4f884
005C4F7D4  ldr      x8, [x21]
005C4F7D8  mov      x0, x21
005C4F7DC  mov      x1, x22
005C4F7E0  ldr      x9, [x8, #0xc08]
005C4F7E4  ldr      x2, [x8, #0xc10]
005C4F7E8  blr      x9
005C4F7EC  cbz      x0, #0x5c4f884
005C4F7F0  ldr      x8, [x0]
005C4F7F4  mov      x1, x20
005C4F7F8  ldr      x9, [x8, #0x388]
005C4F7FC  ldr      x2, [x8, #0x390]
005C4F800  blr      x9
005C4F804  tbz      w0, #0, #0x5c4f818
005C4F808  adrp     x8, #0x8eeb000
005C4F80C  ldr      x0, [x24]
005C4F810  ldr      x8, [x8, #0x148]
005C4F814  b        #0x5c4f5dc ; 
005C4F818  ldr      x0, [x19, #0x20]
005C4F81C  ldrb     w8, [x0, #0x135]
005C4F820  tbnz     w8, #0, #0x5c4f828
005C4F824  bl       #0x3a7e60c ; 
005C4F828  ldr      x8, [x0, #0xc0]
005C4F82C  ldr      x0, [x8, #0x30]
005C4F830  ldrb     w8, [x0, #0x135]
005C4F834  tbnz     w8, #0, #0x5c4f83c
005C4F838  bl       #0x3a7e60c ; 
005C4F83C  bl       #0x382bfa0 ; 
005C4F840  ldr      x8, [x19, #0x20]
005C4F844  mov      x19, x0
005C4F848  ldrb     w9, [x8, #0x135]
005C4F84C  tbnz     w9, #0, #0x5c4f85c
005C4F850  mov      x0, x8
005C4F854  bl       #0x3a7e60c ; 
005C4F858  mov      x8, x0
005C4F85C  ldr      x8, [x8, #0xc0]
005C4F860  mov      x0, x19
005C4F864  ldr      x1, [x8, #0x38]
005C4F868  bl       #0x515c26c ; System.Collections.Generic.ObjectComparer<WeightRandomData>$$.ctor
005C4F86C  mov      x0, x19
005C4F870  ldp      x20, x19, [sp, #0x30]
005C4F874  ldp      x22, x21, [sp, #0x20]
005C4F878  ldp      x24, x23, [sp, #0x10]
005C4F87C  ldr      x30, [sp], #0x40
005C4F880  ret      
005C4F884  bl       #0x382bfb8 ; 
005C4F888  mov      x0, x20
005C4F88C  bl       #0x382c354 ; 
005C4F890  bl       #0x382bfc0 ; 
005C4F894  bl       #0x382bfdc ; 
005C4F898  mov      x1, xzr
005C4F89C  bl       #0x382be7c ; 

; System.Collections.Generic.Comparer<WeightRandomData>$$System.Collections.IComparer.Compare
; RVA 0x5C4F8A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C4F8A0  sub      sp, sp, #0x130
005C4F8A4  stp      x29, x30, [sp, #0x100]
005C4F8A8  stp      x22, x21, [sp, #0x110]
005C4F8AC  stp      x20, x19, [sp, #0x120]
005C4F8B0  mov      x20, x2
005C4F8B4  cbz      x1, #0x5c4fa18
005C4F8B8  cbz      x20, #0x5c4fa38
005C4F8BC  ldr      x8, [x3, #0x20]
005C4F8C0  mov      x22, x1
005C4F8C4  mov      x21, x3
005C4F8C8  mov      x19, x0
005C4F8CC  ldr      x8, [x8, #0xc0]
005C4F8D0  ldr      x1, [x8, #0x40]
005C4F8D4  ldrb     w8, [x1, #0x135]
005C4F8D8  tbnz     w8, #0, #0x5c4f8e8
005C4F8DC  mov      x0, x1
005C4F8E0  bl       #0x3a7e60c ; 
005C4F8E4  mov      x1, x0
005C4F8E8  mov      x0, x22
005C4F8EC  bl       #0x382be90 ; 
005C4F8F0  cbz      x0, #0x5c4fa24
005C4F8F4  ldr      x8, [x21, #0x20]
005C4F8F8  ldr      x8, [x8, #0xc0]
005C4F8FC  ldr      x1, [x8, #0x40]
005C4F900  ldrb     w8, [x1, #0x135]
005C4F904  tbnz     w8, #0, #0x5c4f914
005C4F908  mov      x0, x1
005C4F90C  bl       #0x3a7e60c ; 
005C4F910  mov      x1, x0
005C4F914  mov      x0, x20
005C4F918  bl       #0x382be90 ; 
005C4F91C  cbz      x0, #0x5c4fa24
005C4F920  ldr      x8, [x21, #0x20]
005C4F924  ldr      x8, [x8, #0xc0]
005C4F928  ldr      x1, [x8, #0x40]
005C4F92C  ldrb     w8, [x1, #0x135]
005C4F930  tbnz     w8, #0, #0x5c4f940
005C4F934  mov      x0, x1
005C4F938  bl       #0x3a7e60c ; 
005C4F93C  mov      x1, x0
005C4F940  ldr      x8, [x22]
005C4F944  ldr      x9, [x1, #0x40]
005C4F948  mov      x0, x22
005C4F94C  ldr      x8, [x8, #0x40]
005C4F950  cmp      x8, x9
005C4F954  b.ne     #0x5c4fa50
005C4F958  bl       #0x382be98 ; 
005C4F95C  ldr      x8, [x0, #0x30]
005C4F960  ldp      q1, q0, [x0, #0x10]
005C4F964  ldr      q2, [x0]
005C4F968  str      x8, [sp, #0x70]
005C4F96C  stp      q1, q0, [sp, #0x50]
005C4F970  str      q2, [sp, #0x40]
005C4F974  ldr      x8, [x21, #0x20]
005C4F978  ldr      x8, [x8, #0xc0]
005C4F97C  ldr      x1, [x8, #0x40]
005C4F980  ldrb     w8, [x1, #0x135]
005C4F984  tbnz     w8, #0, #0x5c4f994
005C4F988  mov      x0, x1
005C4F98C  bl       #0x3a7e60c ; 
005C4F990  mov      x1, x0
005C4F994  ldr      x8, [x20]
005C4F998  ldr      x9, [x1, #0x40]
005C4F99C  mov      x0, x20
005C4F9A0  ldr      x8, [x8, #0x40]
005C4F9A4  cmp      x8, x9
005C4F9A8  b.ne     #0x5c4fa50
005C4F9AC  bl       #0x382be98 ; 
005C4F9B0  ldp      q1, q0, [x0, #0x10]
005C4F9B4  ldr      x8, [x0, #0x30]
005C4F9B8  ldr      q2, [x0]
005C4F9BC  ldr      x9, [sp, #0x70]
005C4F9C0  stp      q1, q0, [sp, #0x10]
005C4F9C4  str      x8, [sp, #0x30]
005C4F9C8  str      q2, [sp]
005C4F9CC  ldr      x8, [x19]
005C4F9D0  ldp      q1, q0, [sp, #0x50]
005C4F9D4  ldr      q2, [sp, #0x40]
005C4F9D8  add      x1, sp, #0xc0
005C4F9DC  ldr      x10, [x8, #0x198]
005C4F9E0  stp      q1, q0, [sp, #0xd0]
005C4F9E4  ldp      q0, q3, [sp]
005C4F9E8  ldr      q1, [sp, #0x20]
005C4F9EC  str      x9, [sp, #0xf0]
005C4F9F0  ldr      x9, [sp, #0x30]
005C4F9F4  str      q2, [sp, #0xc0]
005C4F9F8  stp      q0, q3, [sp, #0x80]
005C4F9FC  str      q1, [sp, #0xa0]
005C4FA00  str      x9, [sp, #0xb0]
005C4FA04  ldr      x3, [x8, #0x1a0]
005C4FA08  add      x2, sp, #0x80
005C4FA0C  mov      x0, x19
005C4FA10  blr      x10
005C4FA14  b        #0x5c4fa3c ; 
005C4FA18  cmp      x20, #0
005C4FA1C  csetm    w0, ne
005C4FA20  b        #0x5c4fa3c ; 
005C4FA24  mov      w0, #2
005C4FA28  mov      x1, xzr
005C4FA2C  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
005C4FA30  mov      w0, wzr
005C4FA34  b        #0x5c4fa3c ; 
005C4FA38  mov      w0, #1
005C4FA3C  ldp      x20, x19, [sp, #0x120]
005C4FA40  ldp      x22, x21, [sp, #0x110]
005C4FA44  ldp      x29, x30, [sp, #0x100]
005C4FA48  add      sp, sp, #0x130
005C4FA4C  ret      
005C4FA50  bl       #0x382c354 ; 

; System.Collections.Generic.Comparer<WeightRandomData>$$.ctor
; RVA 0x5C4FA54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C4FA54  mov      x1, xzr
005C4FA58  b        #0x7c335dc ; System.Object$$.ctor

