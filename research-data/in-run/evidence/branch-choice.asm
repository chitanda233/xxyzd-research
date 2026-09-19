; HotFix.BattleLogic.WeightRandom$$RandomOneSubSkillByParent
; RVA 0x66346A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066346A0  sub      sp, sp, #0x80
0066346A4  stp      x29, x30, [sp, #0x20]
0066346A8  stp      x28, x27, [sp, #0x30]
0066346AC  stp      x26, x25, [sp, #0x40]
0066346B0  stp      x24, x23, [sp, #0x50]
0066346B4  stp      x22, x21, [sp, #0x60]
0066346B8  stp      x20, x19, [sp, #0x70]
0066346BC  adrp     x19, #0x9599000
0066346C0  adrp     x23, #0x8f0d000
0066346C4  ldrb     w8, [x19, #0x9ed]
0066346C8  ldr      x23, [x23, #0x40]
0066346CC  mov      x26, x4
0066346D0  mov      x20, x3
0066346D4  mov      x24, x2
0066346D8  mov      w21, w1
0066346DC  mov      x22, x0
0066346E0  tbnz     w8, #0, #0x663474c
0066346E4  adrp     x0, #0x8f0d000
0066346E8  ldr      x0, [x0, #0x48]
0066346EC  bl       #0x382bd14 ; 
0066346F0  adrp     x0, #0x8ebf000
0066346F4  ldr      x0, [x0, #0xba0]
0066346F8  bl       #0x382bd14 ; 
0066346FC  adrp     x0, #0x8f08000
006634700  ldr      x0, [x0, #0x630]
006634704  bl       #0x382bd14 ; 
006634708  adrp     x0, #0x8ec2000
00663470C  ldr      x0, [x0, #0x268]
006634710  bl       #0x382bd14 ; 
006634714  adrp     x0, #0x8ebf000
006634718  ldr      x0, [x0, #0x840]
00663471C  bl       #0x382bd14 ; 
006634720  adrp     x0, #0x8f0d000
006634724  ldr      x0, [x0, #0x40]
006634728  bl       #0x382bd14 ; 
00663472C  adrp     x0, #0x8f0d000
006634730  ldr      x0, [x0, #0x50]
006634734  bl       #0x382bd14 ; 
006634738  adrp     x0, #0x8f0d000
00663473C  ldr      x0, [x0, #0x58]
006634740  bl       #0x382bd14 ; 
006634744  mov      w8, #1
006634748  strb     w8, [x19, #0x9ed]
00663474C  ldr      x5, [x23]
006634750  ldrb     w8, [x5, #0x53]
006634754  tbnz     w8, #5, #0x66347b4
006634758  adrp     x8, #0x8f0d000
00663475C  ldr      x8, [x8, #0x48]
006634760  ldr      x8, [x8]
006634764  ldr      x8, [x8, #0xb8]
006634768  ldr      x0, [x8]
00663476C  cbz      x0, #0x6634f10
006634770  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006634774  adrp     x8, #0x9591000
006634778  ldrb     w8, [x8, #0xa4b]
00663477C  cbnz     w8, #0x6634798
006634780  adrp     x0, #0x8ee5000
006634784  ldr      x0, [x0, #0xb28]
006634788  bl       #0x382bd14 ; 
00663478C  mov      w8, #1
006634790  adrp     x9, #0x9591000
006634794  strb     w8, [x9, #0xa4b]
006634798  adrp     x8, #0x8ee5000
00663479C  ldr      x8, [x8, #0xb28]
0066347A0  ldr      x1, [x8]
0066347A4  ldrb     w8, [x1, #0x53]
0066347A8  tbnz     w8, #5, #0x66347ec
0066347AC  ldr      x25, [x22, #0x20]
0066347B0  b        #0x66347fc ; 
0066347B4  ldr      x6, [x5, #0x60]
0066347B8  mov      x0, x22
0066347BC  mov      w1, w21
0066347C0  mov      x2, x24
0066347C4  mov      x3, x20
0066347C8  mov      x4, x26
0066347CC  ldp      x20, x19, [sp, #0x70]
0066347D0  ldp      x22, x21, [sp, #0x60]
0066347D4  ldp      x24, x23, [sp, #0x50]
0066347D8  ldp      x26, x25, [sp, #0x40]
0066347DC  ldp      x28, x27, [sp, #0x30]
0066347E0  ldp      x29, x30, [sp, #0x20]
0066347E4  add      sp, sp, #0x80
0066347E8  br       x6
0066347EC  ldr      x8, [x1, #0x60]
0066347F0  mov      x0, x22
0066347F4  blr      x8
0066347F8  mov      x25, x0
0066347FC  cbz      x25, #0x6634f10
006634800  adrp     x8, #0x9598000
006634804  ldrb     w8, [x8, #0xfcc]
006634808  cbnz     w8, #0x6634824
00663480C  adrp     x0, #0x8f06000
006634810  ldr      x0, [x0, #0x470]
006634814  bl       #0x382bd14 ; 
006634818  mov      w8, #1
00663481C  adrp     x9, #0x9598000
006634820  strb     w8, [x9, #0xfcc]
006634824  adrp     x8, #0x8f06000
006634828  ldr      x8, [x8, #0x470]
00663482C  ldr      x1, [x8]
006634830  ldrb     w8, [x1, #0x53]
006634834  tbnz     w8, #5, #0x6634840
006634838  ldr      x0, [x25, #0x200]
00663483C  b        #0x663484c ; 
006634840  ldr      x8, [x1, #0x60]
006634844  mov      x0, x25
006634848  blr      x8
00663484C  cbz      x0, #0x6634f10
006634850  mov      w1, w21
006634854  mov      x2, xzr
006634858  str      x24, [sp]
00663485C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006634860  cbz      x0, #0x6634f10
006634864  mov      x1, xzr
006634868  bl       #0x6b0a438 ; LocalModels.Bean.Skill_Main$$GetUpgradeSkillId
00663486C  cbz      x0, #0x6634f10
006634870  ldr      w8, [x0, #0x18]
006634874  mov      x25, x0
006634878  cmp      w8, #1
00663487C  b.lt     #0x6634e30
006634880  adrp     x27, #0x8f09000
006634884  ldr      x27, [x27, #0x300]
006634888  mov      x23, xzr
00663488C  mov      w19, #1
006634890  adrp     x24, #0x9599000
006634894  str      x26, [sp, #8]
006634898  adrp     x8, #0x9591000
00663489C  ldrb     w8, [x8, #0xa4b]
0066348A0  cbnz     w8, #0x66348b8
0066348A4  adrp     x0, #0x8ee5000
0066348A8  ldr      x0, [x0, #0xb28]
0066348AC  bl       #0x382bd14 ; 
0066348B0  adrp     x8, #0x9591000
0066348B4  strb     w19, [x8, #0xa4b]
0066348B8  adrp     x8, #0x8ee5000
0066348BC  ldr      x8, [x8, #0xb28]
0066348C0  ldr      x1, [x8]
0066348C4  ldrb     w8, [x1, #0x53]
0066348C8  tbnz     w8, #5, #0x66348d4
0066348CC  ldr      x21, [x22, #0x20]
0066348D0  b        #0x66348e4 ; 
0066348D4  ldr      x8, [x1, #0x60]
0066348D8  mov      x0, x22
0066348DC  blr      x8
0066348E0  mov      x21, x0
0066348E4  cbz      x21, #0x6634f10
0066348E8  adrp     x8, #0x9598000
0066348EC  ldrb     w8, [x8, #0xfcc]
0066348F0  cbnz     w8, #0x6634908
0066348F4  adrp     x0, #0x8f06000
0066348F8  ldr      x0, [x0, #0x470]
0066348FC  bl       #0x382bd14 ; 
006634900  adrp     x8, #0x9598000
006634904  strb     w19, [x8, #0xfcc]
006634908  adrp     x8, #0x8f06000
00663490C  ldr      x8, [x8, #0x470]
006634910  ldr      x1, [x8]
006634914  ldrb     w8, [x1, #0x53]
006634918  tbnz     w8, #5, #0x6634924
00663491C  ldr      x0, [x21, #0x200]
006634920  b        #0x6634930 ; 
006634924  ldr      x8, [x1, #0x60]
006634928  mov      x0, x21
00663492C  blr      x8
006634930  ldr      w8, [x25, #0x18]
006634934  cmp      x23, x8
006634938  b.hs     #0x6634f14
00663493C  cbz      x0, #0x6634f10
006634940  add      x8, x25, x23, lsl #2
006634944  ldr      w1, [x8, #0x20]
006634948  mov      x2, xzr
00663494C  bl       #0x64d8398 ; LocalModels.LocalModelManager$$GetSkillGroup_BranchSurvivorGroup
006634950  cbz      x0, #0x6634f10
006634954  adrp     x8, #0x9599000
006634958  ldrb     w8, [x8, #0xac9]
00663495C  mov      x29, x0
006634960  cbnz     w8, #0x6634978
006634964  adrp     x0, #0x8f0d000
006634968  ldr      x0, [x0, #0x60]
00663496C  bl       #0x382bd14 ; 
006634970  adrp     x8, #0x9599000
006634974  strb     w19, [x8, #0xac9]
006634978  adrp     x8, #0x8f0d000
00663497C  ldr      x8, [x8, #0x60]
006634980  ldr      x1, [x8]
006634984  ldrb     w8, [x1, #0x53]
006634988  tbnz     w8, #5, #0x6634994
00663498C  ldr      w28, [x29, #0x24]
006634990  b        #0x66349a4 ; 
006634994  ldr      x8, [x1, #0x60]
006634998  mov      x0, x29
00663499C  blr      x8
0066349A0  mov      w28, w0
0066349A4  adrp     x8, #0x9591000
0066349A8  ldrb     w8, [x8, #0xa4b]
0066349AC  cbnz     w8, #0x66349c4
0066349B0  adrp     x0, #0x8ee5000
0066349B4  ldr      x0, [x0, #0xb28]
0066349B8  bl       #0x382bd14 ; 
0066349BC  adrp     x8, #0x9591000
0066349C0  strb     w19, [x8, #0xa4b]
0066349C4  adrp     x8, #0x8ee5000
0066349C8  ldr      x8, [x8, #0xb28]
0066349CC  ldr      x1, [x8]
0066349D0  ldrb     w8, [x1, #0x53]
0066349D4  tbnz     w8, #5, #0x66349e0
0066349D8  ldr      x21, [x22, #0x20]
0066349DC  b        #0x66349f0 ; 
0066349E0  ldr      x8, [x1, #0x60]
0066349E4  mov      x0, x22
0066349E8  blr      x8
0066349EC  mov      x21, x0
0066349F0  cbz      x21, #0x6634f10
0066349F4  adrp     x8, #0x9598000
0066349F8  ldrb     w8, [x8, #0xfcc]
0066349FC  cbnz     w8, #0x6634a14
006634A00  adrp     x0, #0x8f06000
006634A04  ldr      x0, [x0, #0x470]
006634A08  bl       #0x382bd14 ; 
006634A0C  adrp     x8, #0x9598000
006634A10  strb     w19, [x8, #0xfcc]
006634A14  adrp     x8, #0x8f06000
006634A18  ldr      x8, [x8, #0x470]
006634A1C  ldr      x1, [x8]
006634A20  ldrb     w8, [x1, #0x53]
006634A24  tbnz     w8, #5, #0x6634a30
006634A28  ldr      x0, [x21, #0x200]
006634A2C  b        #0x6634a3c ; 
006634A30  ldr      x8, [x1, #0x60]
006634A34  mov      x0, x21
006634A38  blr      x8
006634A3C  mov      x1, x20
006634A40  mov      w2, w28
006634A44  mov      x3, xzr
006634A48  bl       #0x691f410 ; HotFix.BattleLogic.GameUtils$$CheckCanStudySkill
006634A4C  tbz      w0, #0, #0x6634a70
006634A50  cbz      x26, #0x6634f10
006634A54  adrp     x8, #0x8f08000
006634A58  ldr      x8, [x8, #0x630]
006634A5C  mov      x0, x26
006634A60  mov      w1, w28
006634A64  ldr      x2, [x8]
006634A68  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006634A6C  tbz      w0, #0, #0x6634ab4
006634A70  adrp     x8, #0x8ebf000
006634A74  ldr      x8, [x8, #0xba0]
006634A78  add      x1, sp, #0x14
006634A7C  str      w28, [sp, #0x14]
006634A80  ldr      x0, [x8]
006634A84  bl       #0x382be94 ; 
006634A88  adrp     x8, #0x8f0d000
006634A8C  ldr      x8, [x8, #0x50]
006634A90  mov      x1, x0
006634A94  mov      x2, xzr
006634A98  ldr      x8, [x8]
006634A9C  mov      x0, x8
006634AA0  bl       #0x79d140c ; System.String$$Format
006634AA4  mov      x1, x0
006634AA8  mov      x0, x22
006634AAC  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634AB0  b        #0x6634e20 ; 
006634AB4  adrp     x8, #0x9591000
006634AB8  ldrb     w8, [x8, #0xa4b]
006634ABC  cbnz     w8, #0x6634ad4
006634AC0  adrp     x0, #0x8ee5000
006634AC4  ldr      x0, [x0, #0xb28]
006634AC8  bl       #0x382bd14 ; 
006634ACC  adrp     x8, #0x9591000
006634AD0  strb     w19, [x8, #0xa4b]
006634AD4  adrp     x8, #0x8ee5000
006634AD8  ldr      x8, [x8, #0xb28]
006634ADC  ldr      x1, [x8]
006634AE0  ldrb     w8, [x1, #0x53]
006634AE4  tbnz     w8, #5, #0x6634af0
006634AE8  ldr      x21, [x22, #0x20]
006634AEC  b        #0x6634b00 ; 
006634AF0  ldr      x8, [x1, #0x60]
006634AF4  mov      x0, x22
006634AF8  blr      x8
006634AFC  mov      x21, x0
006634B00  cbz      x21, #0x6634f10
006634B04  adrp     x8, #0x9598000
006634B08  ldrb     w8, [x8, #0xfcc]
006634B0C  cbnz     w8, #0x6634b24
006634B10  adrp     x0, #0x8f06000
006634B14  ldr      x0, [x0, #0x470]
006634B18  bl       #0x382bd14 ; 
006634B1C  adrp     x8, #0x9598000
006634B20  strb     w19, [x8, #0xfcc]
006634B24  adrp     x8, #0x8f06000
006634B28  ldr      x8, [x8, #0x470]
006634B2C  ldr      x1, [x8]
006634B30  ldrb     w8, [x1, #0x53]
006634B34  tbnz     w8, #5, #0x6634b40
006634B38  ldr      x0, [x21, #0x200]
006634B3C  b        #0x6634b4c ; 
006634B40  ldr      x8, [x1, #0x60]
006634B44  mov      x0, x21
006634B48  blr      x8
006634B4C  cbz      x0, #0x6634f10
006634B50  mov      w1, w28
006634B54  mov      x2, xzr
006634B58  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006634B5C  cbz      x0, #0x6634f10
006634B60  ldrb     w8, [x24, #0x4c9]
006634B64  mov      x21, x0
006634B68  cbnz     w8, #0x6634b78
006634B6C  mov      x0, x27
006634B70  bl       #0x382bd14 ; 
006634B74  strb     w19, [x24, #0x4c9]
006634B78  ldr      x1, [x27]
006634B7C  ldrb     w8, [x1, #0x53]
006634B80  tbnz     w8, #5, #0x6634b90
006634B84  ldr      x0, [x21, #0x98]
006634B88  cbnz     x0, #0x6634ba0
006634B8C  b        #0x6634c58 ; 
006634B90  ldr      x8, [x1, #0x60]
006634B94  mov      x0, x21
006634B98  blr      x8
006634B9C  cbz      x0, #0x6634c58
006634BA0  mov      x26, xzr
006634BA4  ldrb     w8, [x24, #0x4c9]
006634BA8  cbnz     w8, #0x6634bb8
006634BAC  mov      x0, x27
006634BB0  bl       #0x382bd14 ; 
006634BB4  strb     w19, [x24, #0x4c9]
006634BB8  ldr      x1, [x27]
006634BBC  ldrb     w8, [x1, #0x53]
006634BC0  tbnz     w8, #5, #0x6634bcc
006634BC4  ldr      x0, [x21, #0x98]
006634BC8  b        #0x6634bd8 ; 
006634BCC  ldr      x8, [x1, #0x60]
006634BD0  mov      x0, x21
006634BD4  blr      x8
006634BD8  cbz      x0, #0x6634f10
006634BDC  ldrsw    x8, [x0, #0x18]
006634BE0  cmp      x26, x8
006634BE4  b.ge     #0x6634c58
006634BE8  ldrb     w8, [x24, #0x4c9]
006634BEC  cbnz     w8, #0x6634bfc
006634BF0  mov      x0, x27
006634BF4  bl       #0x382bd14 ; 
006634BF8  strb     w19, [x24, #0x4c9]
006634BFC  ldr      x1, [x27]
006634C00  ldrb     w8, [x1, #0x53]
006634C04  tbnz     w8, #5, #0x6634c10
006634C08  ldr      x0, [x21, #0x98]
006634C0C  b        #0x6634c1c ; 
006634C10  ldr      x8, [x1, #0x60]
006634C14  mov      x0, x21
006634C18  blr      x8
006634C1C  cbz      x0, #0x6634f10
006634C20  ldr      w8, [x0, #0x18]
006634C24  cmp      x26, x8
006634C28  b.hs     #0x6634f14
006634C2C  cbz      x20, #0x6634f10
006634C30  add      x8, x0, x26, lsl #2
006634C34  ldr      w1, [x8, #0x20]
006634C38  adrp     x8, #0x8f08000
006634C3C  ldr      x8, [x8, #0x630]
006634C40  mov      x0, x20
006634C44  ldr      x2, [x8]
006634C48  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006634C4C  tbz      w0, #0, #0x6634d70
006634C50  add      x26, x26, #1
006634C54  b        #0x6634ba4 ; 
006634C58  adrp     x8, #0x9591000
006634C5C  ldrb     w8, [x8, #0xa4b]
006634C60  cbnz     w8, #0x6634c78
006634C64  adrp     x0, #0x8ee5000
006634C68  ldr      x0, [x0, #0xb28]
006634C6C  bl       #0x382bd14 ; 
006634C70  adrp     x8, #0x9591000
006634C74  strb     w19, [x8, #0xa4b]
006634C78  adrp     x8, #0x8ee5000
006634C7C  ldr      x8, [x8, #0xb28]
006634C80  ldr      x1, [x8]
006634C84  ldrb     w8, [x1, #0x53]
006634C88  tbnz     w8, #5, #0x6634c94
006634C8C  ldr      x21, [x22, #0x20]
006634C90  b        #0x6634ca4 ; 
006634C94  ldr      x8, [x1, #0x60]
006634C98  mov      x0, x22
006634C9C  blr      x8
006634CA0  mov      x21, x0
006634CA4  cbz      x21, #0x6634f10
006634CA8  adrp     x8, #0x9598000
006634CAC  ldrb     w8, [x8, #0xfcc]
006634CB0  cbnz     w8, #0x6634cc8
006634CB4  adrp     x0, #0x8f06000
006634CB8  ldr      x0, [x0, #0x470]
006634CBC  bl       #0x382bd14 ; 
006634CC0  adrp     x8, #0x9598000
006634CC4  strb     w19, [x8, #0xfcc]
006634CC8  adrp     x8, #0x8f06000
006634CCC  ldr      x8, [x8, #0x470]
006634CD0  ldr      x1, [x8]
006634CD4  ldrb     w8, [x1, #0x53]
006634CD8  tbnz     w8, #5, #0x6634ce4
006634CDC  ldr      x21, [x21, #0x200]
006634CE0  b        #0x6634cf4 ; 
006634CE4  ldr      x8, [x1, #0x60]
006634CE8  mov      x0, x21
006634CEC  blr      x8
006634CF0  mov      x21, x0
006634CF4  adrp     x8, #0x8f0d000
006634CF8  ldr      x8, [x8, #0x48]
006634CFC  adrp     x9, #0x9599000
006634D00  ldrb     w9, [x9, #0xaca]
006634D04  ldr      x8, [x8]
006634D08  ldr      x8, [x8, #0xb8]
006634D0C  ldr      x26, [x8]
006634D10  cbnz     w9, #0x6634d28
006634D14  adrp     x0, #0x8f0d000
006634D18  ldr      x0, [x0, #0x68]
006634D1C  bl       #0x382bd14 ; 
006634D20  adrp     x8, #0x9599000
006634D24  strb     w19, [x8, #0xaca]
006634D28  adrp     x8, #0x8f0d000
006634D2C  ldr      x8, [x8, #0x68]
006634D30  ldr      x1, [x8]
006634D34  ldrb     w8, [x1, #0x53]
006634D38  tbnz     w8, #5, #0x6634d44
006634D3C  ldr      w3, [x29, #0x28]
006634D40  b        #0x6634d54 ; 
006634D44  ldr      x8, [x1, #0x60]
006634D48  mov      x0, x29
006634D4C  blr      x8
006634D50  mov      w3, w0
006634D54  mov      x0, x21
006634D58  mov      x1, x26
006634D5C  mov      w2, w28
006634D60  mov      x4, x20
006634D64  mov      x5, xzr
006634D68  bl       #0x691f57c ; HotFix.BattleLogic.GameUtils$$AddSkillToRandom
006634D6C  b        #0x6634e1c ; 
006634D70  adrp     x8, #0x8ebf000
006634D74  ldr      x8, [x8, #0xba0]
006634D78  add      x1, sp, #0x1c
006634D7C  str      w28, [sp, #0x1c]
006634D80  ldr      x0, [x8]
006634D84  bl       #0x382be94 ; 
006634D88  ldrb     w8, [x24, #0x4c9]
006634D8C  mov      x28, x0
006634D90  cbnz     w8, #0x6634da0
006634D94  mov      x0, x27
006634D98  bl       #0x382bd14 ; 
006634D9C  strb     w19, [x24, #0x4c9]
006634DA0  ldr      x1, [x27]
006634DA4  ldrb     w8, [x1, #0x53]
006634DA8  tbnz     w8, #5, #0x6634db4
006634DAC  ldr      x0, [x21, #0x98]
006634DB0  b        #0x6634dc0 ; 
006634DB4  ldr      x8, [x1, #0x60]
006634DB8  mov      x0, x21
006634DBC  blr      x8
006634DC0  cbz      x0, #0x6634f10
006634DC4  ldr      w8, [x0, #0x18]
006634DC8  cmp      w26, w8
006634DCC  b.hs     #0x6634f14
006634DD0  add      x8, x0, x26, lsl #2
006634DD4  adrp     x9, #0x8ebf000
006634DD8  ldr      w8, [x8, #0x20]
006634DDC  ldr      x9, [x9, #0xba0]
006634DE0  add      x1, sp, #0x18
006634DE4  str      w8, [sp, #0x18]
006634DE8  ldr      x0, [x9]
006634DEC  bl       #0x382be94 ; 
006634DF0  adrp     x8, #0x8f0d000
006634DF4  ldr      x8, [x8, #0x58]
006634DF8  mov      x2, x0
006634DFC  mov      x1, x28
006634E00  mov      x3, xzr
006634E04  ldr      x8, [x8]
006634E08  mov      x0, x8
006634E0C  bl       #0x79e2794 ; System.String$$Format
006634E10  mov      x1, x0
006634E14  mov      x0, x22
006634E18  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634E1C  ldr      x26, [sp, #8]
006634E20  ldrsw    x8, [x25, #0x18]
006634E24  add      x23, x23, #1
006634E28  cmp      x23, x8
006634E2C  b.lt     #0x6634898
006634E30  adrp     x8, #0x8f0d000
006634E34  ldr      x8, [x8, #0x48]
006634E38  ldr      x8, [x8]
006634E3C  ldr      x8, [x8, #0xb8]
006634E40  ldr      x0, [x8]
006634E44  cbz      x0, #0x6634f10
006634E48  ldr      x19, [sp]
006634E4C  mov      x1, x19
006634E50  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006634E54  cmp      w0, #1
006634E58  b.lt     #0x6634ef0
006634E5C  adrp     x8, #0x8ebf000
006634E60  ldr      x8, [x8, #0x840]
006634E64  mov      w21, w0
006634E68  ldr      x0, [x8]
006634E6C  ldr      w8, [x0, #0xe0]
006634E70  cbnz     w8, #0x6634e78
006634E74  bl       #0x382be8c ; 
006634E78  mov      w1, #1
006634E7C  mov      w0, w21
006634E80  mov      x2, xzr
006634E84  bl       #0x7bd69a0 ; System.Math$$Min
006634E88  adrp     x8, #0x8f0d000
006634E8C  ldr      x8, [x8, #0x48]
006634E90  ldr      x8, [x8]
006634E94  ldr      x8, [x8, #0xb8]
006634E98  ldr      x8, [x8]
006634E9C  cbz      x8, #0x6634f10
006634EA0  mov      w21, w0
006634EA4  mov      x0, x8
006634EA8  mov      x1, x19
006634EAC  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006634EB0  mov      w1, w0
006634EB4  mov      w0, w21
006634EB8  mov      x2, xzr
006634EBC  bl       #0x7bd69a0 ; System.Math$$Min
006634EC0  cbz      x19, #0x6634f10
006634EC4  adrp     x8, #0x8f0d000
006634EC8  ldr      x8, [x8, #0x48]
006634ECC  mov      w1, w0
006634ED0  ldr      x8, [x8]
006634ED4  ldr      x8, [x8, #0xb8]
006634ED8  ldr      x0, [x8]
006634EDC  cbz      x0, #0x6634f10
006634EE0  mov      x2, x19
006634EE4  mov      x3, x20
006634EE8  mov      x4, x26
006634EEC  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
006634EF0  ldp      x20, x19, [sp, #0x70]
006634EF4  ldp      x22, x21, [sp, #0x60]
006634EF8  ldp      x24, x23, [sp, #0x50]
006634EFC  ldp      x26, x25, [sp, #0x40]
006634F00  ldp      x28, x27, [sp, #0x30]
006634F04  ldp      x29, x30, [sp, #0x20]
006634F08  add      sp, sp, #0x80
006634F0C  ret      
006634F10  bl       #0x382bfb8 ; 
006634F14  bl       #0x382bfc0 ; 

