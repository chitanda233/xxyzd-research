; LocalModels.Bean.SkillGroup_SurvivorGroup$$GetWeightByGroup
; RVA 0x6AFC698; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFC698  str      x30, [sp, #-0x30]!
006AFC69C  stp      x22, x21, [sp, #0x10]
006AFC6A0  stp      x20, x19, [sp, #0x20]
006AFC6A4  adrp     x21, #0x959f000
006AFC6A8  adrp     x22, #0x8f3d000
006AFC6AC  ldrb     w8, [x21, #0x32d]
006AFC6B0  ldr      x22, [x22, #0xf10] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.GetWeightByGroup() @ 0x92ab690
006AFC6B4  mov      w20, w1
006AFC6B8  mov      x19, x0
006AFC6BC  tbnz     w8, #0, #0x6afc6d4
006AFC6C0  adrp     x0, #0x8f3d000
006AFC6C4  ldr      x0, [x0, #0xf10] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.GetWeightByGroup() @ 0x92ab690
006AFC6C8  bl       #0x382bd14 ; 
006AFC6CC  mov      w8, #1
006AFC6D0  strb     w8, [x21, #0x32d]
006AFC6D4  ldr      x2, [x22]
006AFC6D8  ldrb     w8, [x2, #0x53]
006AFC6DC  tbnz     w8, #5, #0x6afc740
006AFC6E0  sub      w8, w20, #1
006AFC6E4  cmp      w8, #9
006AFC6E8  b.hi     #0x6afc75c
006AFC6EC  adrp     x9, #0x1a72000
006AFC6F0  add      x9, x9, #0x709
006AFC6F4  adr      x10, #0x6afc704
006AFC6F8  ldrb     w11, [x9, x8]
006AFC6FC  add      x10, x10, x11, lsl #2
006AFC700  br       x10
006AFC704  adrp     x20, #0x959f000
006AFC708  ldrb     w8, [x20, #0x8b4]
006AFC70C  cbnz     w8, #0x6afc724
006AFC710  adrp     x0, #0x8f3d000
006AFC714  ldr      x0, [x0, #0xe48] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_1() @ 0x92ab6c0
006AFC718  bl       #0x382bd14 ; 
006AFC71C  mov      w8, #1
006AFC720  strb     w8, [x20, #0x8b4]
006AFC724  adrp     x8, #0x8f3d000
006AFC728  ldr      x8, [x8, #0xe48] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_1() @ 0x92ab6c0
006AFC72C  ldr      x1, [x8]
006AFC730  ldrb     w8, [x1, #0x53]
006AFC734  tbnz     w8, #5, #0x6afc9c0
006AFC738  ldr      w0, [x19, #0x34]
006AFC73C  b        #0x6afc9b0 ; 
006AFC740  ldr      x3, [x2, #0x60]
006AFC744  mov      x0, x19
006AFC748  mov      w1, w20
006AFC74C  ldp      x20, x19, [sp, #0x20]
006AFC750  ldp      x22, x21, [sp, #0x10]
006AFC754  ldr      x30, [sp], #0x30
006AFC758  br       x3
006AFC75C  adrp     x20, #0x959f000
006AFC760  ldrb     w8, [x20, #0x8be]
006AFC764  cbnz     w8, #0x6afc77c
006AFC768  adrp     x0, #0x8f3d000
006AFC76C  ldr      x0, [x0, #0xe38] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight() @ 0x92ab6b0
006AFC770  bl       #0x382bd14 ; 
006AFC774  mov      w8, #1
006AFC778  strb     w8, [x20, #0x8be]
006AFC77C  adrp     x8, #0x8f3d000
006AFC780  ldr      x8, [x8, #0xe38] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight() @ 0x92ab6b0
006AFC784  ldr      x1, [x8]
006AFC788  ldrb     w8, [x1, #0x53]
006AFC78C  tbnz     w8, #5, #0x6afc9c0
006AFC790  ldr      w0, [x19, #0x30]
006AFC794  b        #0x6afc9b0 ; 
006AFC798  adrp     x20, #0x959f000
006AFC79C  ldrb     w8, [x20, #0x8b5]
006AFC7A0  cbnz     w8, #0x6afc7b8
006AFC7A4  adrp     x0, #0x8f3d000
006AFC7A8  ldr      x0, [x0, #0xe58] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_2() @ 0x92ab6d0
006AFC7AC  bl       #0x382bd14 ; 
006AFC7B0  mov      w8, #1
006AFC7B4  strb     w8, [x20, #0x8b5]
006AFC7B8  adrp     x8, #0x8f3d000
006AFC7BC  ldr      x8, [x8, #0xe58] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_2() @ 0x92ab6d0
006AFC7C0  ldr      x1, [x8]
006AFC7C4  ldrb     w8, [x1, #0x53]
006AFC7C8  tbnz     w8, #5, #0x6afc9c0
006AFC7CC  ldr      w0, [x19, #0x38]
006AFC7D0  b        #0x6afc9b0 ; 
006AFC7D4  adrp     x20, #0x959f000
006AFC7D8  ldrb     w8, [x20, #0x8b6]
006AFC7DC  cbnz     w8, #0x6afc7f4
006AFC7E0  adrp     x0, #0x8f3d000
006AFC7E4  ldr      x0, [x0, #0xe68] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_3() @ 0x92ab6d8
006AFC7E8  bl       #0x382bd14 ; 
006AFC7EC  mov      w8, #1
006AFC7F0  strb     w8, [x20, #0x8b6]
006AFC7F4  adrp     x8, #0x8f3d000
006AFC7F8  ldr      x8, [x8, #0xe68] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_3() @ 0x92ab6d8
006AFC7FC  ldr      x1, [x8]
006AFC800  ldrb     w8, [x1, #0x53]
006AFC804  tbnz     w8, #5, #0x6afc9c0
006AFC808  ldr      w0, [x19, #0x3c]
006AFC80C  b        #0x6afc9b0 ; 
006AFC810  adrp     x20, #0x959f000
006AFC814  ldrb     w8, [x20, #0x8b7]
006AFC818  cbnz     w8, #0x6afc830
006AFC81C  adrp     x0, #0x8f3d000
006AFC820  ldr      x0, [x0, #0xe78] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_4() @ 0x92ab6e0
006AFC824  bl       #0x382bd14 ; 
006AFC828  mov      w8, #1
006AFC82C  strb     w8, [x20, #0x8b7]
006AFC830  adrp     x8, #0x8f3d000
006AFC834  ldr      x8, [x8, #0xe78] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_4() @ 0x92ab6e0
006AFC838  ldr      x1, [x8]
006AFC83C  ldrb     w8, [x1, #0x53]
006AFC840  tbnz     w8, #5, #0x6afc9c0
006AFC844  ldr      w0, [x19, #0x40]
006AFC848  b        #0x6afc9b0 ; 
006AFC84C  adrp     x20, #0x959f000
006AFC850  ldrb     w8, [x20, #0x8b8]
006AFC854  cbnz     w8, #0x6afc86c
006AFC858  adrp     x0, #0x8f3d000
006AFC85C  ldr      x0, [x0, #0xe88] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_5() @ 0x92ab6e8
006AFC860  bl       #0x382bd14 ; 
006AFC864  mov      w8, #1
006AFC868  strb     w8, [x20, #0x8b8]
006AFC86C  adrp     x8, #0x8f3d000
006AFC870  ldr      x8, [x8, #0xe88] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_5() @ 0x92ab6e8
006AFC874  ldr      x1, [x8]
006AFC878  ldrb     w8, [x1, #0x53]
006AFC87C  tbnz     w8, #5, #0x6afc9c0
006AFC880  ldr      w0, [x19, #0x44]
006AFC884  b        #0x6afc9b0 ; 
006AFC888  adrp     x20, #0x959f000
006AFC88C  ldrb     w8, [x20, #0x8b9]
006AFC890  cbnz     w8, #0x6afc8a8
006AFC894  adrp     x0, #0x8f3d000
006AFC898  ldr      x0, [x0, #0xe98] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_6() @ 0x92ab6f0
006AFC89C  bl       #0x382bd14 ; 
006AFC8A0  mov      w8, #1
006AFC8A4  strb     w8, [x20, #0x8b9]
006AFC8A8  adrp     x8, #0x8f3d000
006AFC8AC  ldr      x8, [x8, #0xe98] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_6() @ 0x92ab6f0
006AFC8B0  ldr      x1, [x8]
006AFC8B4  ldrb     w8, [x1, #0x53]
006AFC8B8  tbnz     w8, #5, #0x6afc9c0
006AFC8BC  ldr      w0, [x19, #0x48]
006AFC8C0  b        #0x6afc9b0 ; 
006AFC8C4  adrp     x20, #0x959f000
006AFC8C8  ldrb     w8, [x20, #0x8ba]
006AFC8CC  cbnz     w8, #0x6afc8e4
006AFC8D0  adrp     x0, #0x8f3d000
006AFC8D4  ldr      x0, [x0, #0xea8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_7() @ 0x92ab6f8
006AFC8D8  bl       #0x382bd14 ; 
006AFC8DC  mov      w8, #1
006AFC8E0  strb     w8, [x20, #0x8ba]
006AFC8E4  adrp     x8, #0x8f3d000
006AFC8E8  ldr      x8, [x8, #0xea8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_7() @ 0x92ab6f8
006AFC8EC  ldr      x1, [x8]
006AFC8F0  ldrb     w8, [x1, #0x53]
006AFC8F4  tbnz     w8, #5, #0x6afc9c0
006AFC8F8  ldr      w0, [x19, #0x4c]
006AFC8FC  b        #0x6afc9b0 ; 
006AFC900  adrp     x20, #0x959f000
006AFC904  ldrb     w8, [x20, #0x8bb]
006AFC908  cbnz     w8, #0x6afc920
006AFC90C  adrp     x0, #0x8f3d000
006AFC910  ldr      x0, [x0, #0xeb8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_8() @ 0x92ab700
006AFC914  bl       #0x382bd14 ; 
006AFC918  mov      w8, #1
006AFC91C  strb     w8, [x20, #0x8bb]
006AFC920  adrp     x8, #0x8f3d000
006AFC924  ldr      x8, [x8, #0xeb8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_8() @ 0x92ab700
006AFC928  ldr      x1, [x8]
006AFC92C  ldrb     w8, [x1, #0x53]
006AFC930  tbnz     w8, #5, #0x6afc9c0
006AFC934  ldr      w0, [x19, #0x50]
006AFC938  b        #0x6afc9b0 ; 
006AFC93C  adrp     x20, #0x959f000
006AFC940  ldrb     w8, [x20, #0x8bc]
006AFC944  cbnz     w8, #0x6afc95c
006AFC948  adrp     x0, #0x8f3d000
006AFC94C  ldr      x0, [x0, #0xec8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_9() @ 0x92ab708
006AFC950  bl       #0x382bd14 ; 
006AFC954  mov      w8, #1
006AFC958  strb     w8, [x20, #0x8bc]
006AFC95C  adrp     x8, #0x8f3d000
006AFC960  ldr      x8, [x8, #0xec8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_9() @ 0x92ab708
006AFC964  ldr      x1, [x8]
006AFC968  ldrb     w8, [x1, #0x53]
006AFC96C  tbnz     w8, #5, #0x6afc9c0
006AFC970  ldr      w0, [x19, #0x54]
006AFC974  b        #0x6afc9b0 ; 
006AFC978  adrp     x20, #0x959f000
006AFC97C  ldrb     w8, [x20, #0x8bd]
006AFC980  cbnz     w8, #0x6afc998
006AFC984  adrp     x0, #0x8f3d000
006AFC988  ldr      x0, [x0, #0xed8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_10() @ 0x92ab6c8
006AFC98C  bl       #0x382bd14 ; 
006AFC990  mov      w8, #1
006AFC994  strb     w8, [x20, #0x8bd]
006AFC998  adrp     x8, #0x8f3d000
006AFC99C  ldr      x8, [x8, #0xed8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_Weight_10() @ 0x92ab6c8
006AFC9A0  ldr      x1, [x8]
006AFC9A4  ldrb     w8, [x1, #0x53]
006AFC9A8  tbnz     w8, #5, #0x6afc9c0
006AFC9AC  ldr      w0, [x19, #0x58]
006AFC9B0  ldp      x20, x19, [sp, #0x20]
006AFC9B4  ldp      x22, x21, [sp, #0x10]
006AFC9B8  ldr      x30, [sp], #0x30
006AFC9BC  ret      
006AFC9C0  ldr      x2, [x1, #0x60]
006AFC9C4  mov      x0, x19
006AFC9C8  ldp      x20, x19, [sp, #0x20]
006AFC9CC  ldp      x22, x21, [sp, #0x10]
006AFC9D0  ldr      x30, [sp], #0x30
006AFC9D4  br       x2

