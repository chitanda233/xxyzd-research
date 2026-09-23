; HotFix.BattleResultViewMainModule$$OnCreate
; RVA 0x7370340; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007370340  stp      x30, x23, [sp, #-0x30]!
007370344  stp      x22, x21, [sp, #0x10]
007370348  stp      x20, x19, [sp, #0x20]
00737034C  adrp     x21, #0x95a7000
007370350  adrp     x22, #0x8f92000
007370354  ldrb     w8, [x21, #0xa33]
007370358  ldr      x22, [x22, #0xe28]
00737035C  mov      x20, x1
007370360  mov      x19, x0
007370364  tbnz     w8, #0, #0x73703ac
007370368  adrp     x0, #0x8ec1000
00737036C  ldr      x0, [x0, #0x6e8]
007370370  bl       #0x382bd14 ;
007370374  adrp     x0, #0x8f92000
007370378  ldr      x0, [x0, #0xe30]
00737037C  bl       #0x382bd14 ;
007370380  adrp     x0, #0x8f92000
007370384  ldr      x0, [x0, #0xe38]
007370388  bl       #0x382bd14 ;
00737038C  adrp     x0, #0x8f92000
007370390  ldr      x0, [x0, #0xe28]
007370394  bl       #0x382bd14 ;
007370398  adrp     x0, #0x8ebf000
00737039C  ldr      x0, [x0, #0xe98]
0073703A0  bl       #0x382bd14 ;
0073703A4  mov      w8, #1
0073703A8  strb     w8, [x21, #0xa33]
0073703AC  ldr      x2, [x22]
0073703B0  ldrb     w8, [x2, #0x53]
0073703B4  tbnz     w8, #5, #0x7370498
0073703B8  adrp     x8, #0x8ec1000
0073703BC  ldr      x8, [x8, #0x6e8]
0073703C0  adrp     x22, #0x8f92000
0073703C4  ldr      x20, [x19, #0x78]
0073703C8  ldr      x0, [x8]
0073703CC  ldr      x22, [x22, #0xe30]
0073703D0  bl       #0x382bfa0 ;
0073703D4  ldr      x2, [x22]
0073703D8  mov      x1, x19
0073703DC  mov      x3, xzr
0073703E0  mov      x21, x0
0073703E4  bl       #0x7ade578 ; System.Action$$.ctor
0073703E8  cbz      x20, #0x73704b4
0073703EC  mov      x0, x20
0073703F0  mov      x1, x21
0073703F4  mov      x2, xzr
0073703F8  mov      x3, xzr
0073703FC  mov      x4, xzr
007370400  bl       #0x74a4d3c ; HotFix.CommonPopShowCtrl$$Init
007370404  ldr      x8, [x19, #0xb8]
007370408  cbz      x8, #0x73704b4
00737040C  adrp     x23, #0x8ebf000
007370410  ldr      x20, [x8, #0x100]
007370414  ldr      x23, [x23, #0xe98]
007370418  ldr      x0, [x23]
00737041C  bl       #0x382bfa0 ;
007370420  adrp     x8, #0x8f92000
007370424  ldr      x8, [x8, #0xe38]
007370428  mov      x1, x19
00737042C  mov      x3, xzr
007370430  mov      x21, x0
007370434  ldr      x2, [x8]
007370438  bl       #0x8766ba8 ; UnityEngine.Events.UnityAction$$.ctor
00737043C  cbz      x20, #0x73704b4
007370440  mov      x0, x20
007370444  mov      x1, x21
007370448  mov      x2, xzr
00737044C  bl       #0x8766ca4 ; UnityEngine.Events.UnityEvent$$AddListener
007370450  ldr      x8, [x19, #0xb0]
007370454  cbz      x8, #0x73704b4
007370458  ldr      x0, [x23]
00737045C  ldr      x20, [x8, #0x100]
007370460  bl       #0x382bfa0 ;
007370464  ldr      x2, [x22]
007370468  mov      x1, x19
00737046C  mov      x3, xzr
007370470  mov      x21, x0
007370474  bl       #0x8766ba8 ; UnityEngine.Events.UnityAction$$.ctor
007370478  cbz      x20, #0x73704b4
00737047C  mov      x0, x20
007370480  mov      x1, x21
007370484  ldp      x20, x19, [sp, #0x20]
007370488  ldp      x22, x21, [sp, #0x10]
00737048C  mov      x2, xzr
007370490  ldp      x30, x23, [sp], #0x30
007370494  b        #0x8766ca4 ; UnityEngine.Events.UnityEvent$$AddListener
007370498  ldr      x3, [x2, #0x60]
00737049C  mov      x0, x19
0073704A0  mov      x1, x20
0073704A4  ldp      x20, x19, [sp, #0x20]
0073704A8  ldp      x22, x21, [sp, #0x10]
0073704AC  ldp      x30, x23, [sp], #0x30
0073704B0  br       x3
0073704B4  bl       #0x382bfb8 ;

; HotFix.BattleResultViewMainModule$$OnDelete
; RVA 0x73704B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0073704B8  stp      x30, x21, [sp, #-0x20]!
0073704BC  stp      x20, x19, [sp, #0x10]
0073704C0  adrp     x20, #0x95a7000
0073704C4  adrp     x21, #0x8f92000
0073704C8  ldrb     w8, [x20, #0xa34]
0073704CC  ldr      x21, [x21, #0xe40]
0073704D0  mov      x19, x0
0073704D4  tbnz     w8, #0, #0x73704f8
0073704D8  adrp     x0, #0x8f92000
0073704DC  ldr      x0, [x0, #0xe40]
0073704E0  bl       #0x382bd14 ;
0073704E4  adrp     x0, #0x8ee1000
0073704E8  ldr      x0, [x0, #0x5e0]
0073704EC  bl       #0x382bd14 ;
0073704F0  mov      w8, #1
0073704F4  strb     w8, [x20, #0xa34]
0073704F8  ldr      x1, [x21]
0073704FC  ldrb     w8, [x1, #0x53]
007370500  tbnz     w8, #5, #0x73705ac
007370504  adrp     x20, #0x8ee1000
007370508  ldr      x20, [x20, #0x5e0]
00737050C  ldr      x0, [x20]
007370510  ldr      w8, [x0, #0xe0]
007370514  cbnz     w8, #0x737051c
007370518  bl       #0x382be8c ;
00737051C  adrp     x21, #0x9591000
007370520  ldrb     w8, [x21, #0x5ba]
007370524  cbnz     w8, #0x737053c
007370528  adrp     x0, #0x8ee1000
00737052C  ldr      x0, [x0, #0x5e0]
007370530  bl       #0x382bd14 ;
007370534  mov      w8, #1
007370538  strb     w8, [x21, #0x5ba]
00737053C  ldr      x0, [x20]
007370540  ldr      w8, [x0, #0xe0]
007370544  cbnz     w8, #0x7370550
007370548  bl       #0x382be8c ;
00737054C  ldr      x0, [x20]
007370550  ldr      x8, [x0, #0xb8]
007370554  mov      w1, #0x11c
007370558  mov      x2, xzr
00737055C  ldr      x0, [x8, #0x10]
007370560  bl       #0x7263220 ; HotFix.FrameworkExpand$$DispatchNow
007370564  ldr      x8, [x19, #0xb8]
007370568  cbz      x8, #0x73705c0
00737056C  ldr      x0, [x8, #0x100]
007370570  cbz      x0, #0x73705c0
007370574  mov      x1, xzr
007370578  bl       #0x8766a08 ; UnityEngine.Events.UnityEventBase$$RemoveAllListeners
00737057C  ldr      x8, [x19, #0xb0]
007370580  cbz      x8, #0x73705c0
007370584  ldr      x0, [x8, #0x100]
007370588  cbz      x0, #0x73705c0
00737058C  mov      x1, xzr
007370590  bl       #0x8766a08 ; UnityEngine.Events.UnityEventBase$$RemoveAllListeners
007370594  ldr      x0, [x19, #0x78]
007370598  cbz      x0, #0x73705c0
00737059C  ldp      x20, x19, [sp, #0x10]
0073705A0  mov      x1, xzr
0073705A4  ldp      x30, x21, [sp], #0x20
0073705A8  b        #0x74a4fa4 ; HotFix.CommonPopShowCtrl$$DeInit
0073705AC  ldr      x2, [x1, #0x60]
0073705B0  mov      x0, x19
0073705B4  ldp      x20, x19, [sp, #0x10]
0073705B8  ldp      x30, x21, [sp], #0x20
0073705BC  br       x2
0073705C0  bl       #0x382bfb8 ;

; HotFix.BattleResultViewMainModule$$OnOpen
; RVA 0x73705C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0073705C4  sub      sp, sp, #0xa0
0073705C8  stp      d13, d12, [sp, #0x10]
0073705CC  stp      d11, d10, [sp, #0x20]
0073705D0  stp      d9, d8, [sp, #0x30]
0073705D4  stp      x29, x30, [sp, #0x40]
0073705D8  stp      x28, x27, [sp, #0x50]
0073705DC  stp      x26, x25, [sp, #0x60]
0073705E0  stp      x24, x23, [sp, #0x70]
0073705E4  stp      x22, x21, [sp, #0x80]
0073705E8  stp      x20, x19, [sp, #0x90]
0073705EC  adrp     x20, #0x95a7000
0073705F0  adrp     x22, #0x8f92000
0073705F4  ldrb     w8, [x20, #0xa35]
0073705F8  ldr      x22, [x22, #0xe48]
0073705FC  mov      x21, x1
007370600  mov      x19, x0
007370604  tbnz     w8, #0, #0x73707b4
007370608  adrp     x0, #0x8ec3000
00737060C  ldr      x0, [x0, #0xdc0]
007370610  bl       #0x382bd14 ;
007370614  adrp     x0, #0x8f92000
007370618  ldr      x0, [x0, #0xe48]
00737061C  bl       #0x382bd14 ;
007370620  adrp     x0, #0x8f92000
007370624  ldr      x0, [x0, #0xe50]
007370628  bl       #0x382bd14 ;
00737062C  adrp     x0, #0x8efd000
007370630  ldr      x0, [x0, #0x3b0]
007370634  bl       #0x382bd14 ;
007370638  adrp     x0, #0x8f86000
00737063C  ldr      x0, [x0, #0x7a8]
007370640  bl       #0x382bd14 ;
007370644  adrp     x0, #0x8ee8000
007370648  ldr      x0, [x0, #0x898]
00737064C  bl       #0x382bd14 ;
007370650  adrp     x0, #0x8f92000
007370654  ldr      x0, [x0, #0xe58]
007370658  bl       #0x382bd14 ;
00737065C  adrp     x0, #0x8ee6000
007370660  ldr      x0, [x0, #0x88]
007370664  bl       #0x382bd14 ;
007370668  adrp     x0, #0x8ee1000
00737066C  ldr      x0, [x0, #0x5e0]
007370670  bl       #0x382bd14 ;
007370674  adrp     x0, #0x8eeb000
007370678  ldr      x0, [x0, #0xcf8]
00737067C  bl       #0x382bd14 ;
007370680  adrp     x0, #0x8ee6000
007370684  ldr      x0, [x0, #0x680]
007370688  bl       #0x382bd14 ;
00737068C  adrp     x0, #0x8f08000
007370690  ldr      x0, [x0, #0x40]
007370694  bl       #0x382bd14 ;
007370698  adrp     x0, #0x8ebf000
00737069C  ldr      x0, [x0, #0xba0]
0073706A0  bl       #0x382bd14 ;
0073706A4  adrp     x0, #0x8f89000
0073706A8  ldr      x0, [x0, #0xe30]
0073706AC  bl       #0x382bd14 ;
0073706B0  adrp     x0, #0x8f89000
0073706B4  ldr      x0, [x0, #0xe38]
0073706B8  bl       #0x382bd14 ;
0073706BC  adrp     x0, #0x8f89000
0073706C0  ldr      x0, [x0, #0xe40]
0073706C4  bl       #0x382bd14 ;
0073706C8  adrp     x0, #0x8f89000
0073706CC  ldr      x0, [x0, #0xe48]
0073706D0  bl       #0x382bd14 ;
0073706D4  adrp     x0, #0x8f7c000
0073706D8  ldr      x0, [x0, #0x460]
0073706DC  bl       #0x382bd14 ;
0073706E0  adrp     x0, #0x8f86000
0073706E4  ldr      x0, [x0, #0x7b0]
0073706E8  bl       #0x382bd14 ;
0073706EC  adrp     x0, #0x8f6b000
0073706F0  ldr      x0, [x0, #0x680]
0073706F4  bl       #0x382bd14 ;
0073706F8  adrp     x0, #0x8ec2000
0073706FC  ldr      x0, [x0, #0xbc8]
007370700  bl       #0x382bd14 ;
007370704  adrp     x0, #0x8f74000
007370708  ldr      x0, [x0, #0xc40]
00737070C  bl       #0x382bd14 ;
007370710  adrp     x0, #0x8ec3000
007370714  ldr      x0, [x0, #0xf70]
007370718  bl       #0x382bd14 ;
00737071C  adrp     x0, #0x8ec0000
007370720  ldr      x0, [x0, #0xc40]
007370724  bl       #0x382bd14 ;
007370728  adrp     x0, #0x8ef8000
00737072C  ldr      x0, [x0, #0x30]
007370730  bl       #0x382bd14 ;
007370734  adrp     x0, #0x8f92000
007370738  ldr      x0, [x0, #0xe60]
00737073C  bl       #0x382bd14 ;
007370740  adrp     x0, #0x8f92000
007370744  ldr      x0, [x0, #0xe68]
007370748  bl       #0x382bd14 ;
00737074C  adrp     x0, #0x8f92000
007370750  ldr      x0, [x0, #0xe70]
007370754  bl       #0x382bd14 ;
007370758  adrp     x0, #0x8f57000
00737075C  ldr      x0, [x0, #0xd70]
007370760  bl       #0x382bd14 ;
007370764  adrp     x0, #0x8f92000
007370768  ldr      x0, [x0, #0xe78]
00737076C  bl       #0x382bd14 ;
007370770  adrp     x0, #0x8f92000
007370774  ldr      x0, [x0, #0xe80]
007370778  bl       #0x382bd14 ;
00737077C  adrp     x0, #0x8f92000
007370780  ldr      x0, [x0, #0xe88]
007370784  bl       #0x382bd14 ;
007370788  adrp     x0, #0x8f92000
00737078C  ldr      x0, [x0, #0xe90]
007370790  bl       #0x382bd14 ;
007370794  adrp     x0, #0x8f92000
007370798  ldr      x0, [x0, #0xe98]
00737079C  bl       #0x382bd14 ;
0073707A0  adrp     x0, #0x8f92000
0073707A4  ldr      x0, [x0, #0xea0]
0073707A8  bl       #0x382bd14 ;
0073707AC  mov      w8, #1
0073707B0  strb     w8, [x20, #0xa35]
0073707B4  ldr      x2, [x22]
0073707B8  ldrb     w8, [x2, #0x53]
0073707BC  tbnz     w8, #5, #0x737083c
0073707C0  mov      x0, x19
0073707C4  mov      x1, x21
0073707C8  bl       #0x736aec4 ; HotFix.BaseResulViewModule$$OnOpen
0073707CC  mov      x0, x19
0073707D0  strb     wzr, [x19, #0x150]
0073707D4  bl       #0x736b2ac ; HotFix.BaseResulViewModule$$StartOpen
0073707D8  cbz      x21, #0x7370874
0073707DC  adrp     x8, #0x8f74000
0073707E0  ldr      x8, [x8, #0xc40]
0073707E4  ldr      x9, [x21]
0073707E8  ldr      x1, [x8]
0073707EC  ldrb     w10, [x9, #0x130]
0073707F0  ldrb     w8, [x1, #0x130]
0073707F4  cmp      w10, w8
0073707F8  b.lo     #0x7371570
0073707FC  ldr      x10, [x9, #0xc8]
007370800  sub      x9, x8, #1
007370804  ldr      x10, [x10, x9, lsl #3]
007370808  cmp      x10, x1
00737080C  b.ne     #0x7371570
007370810  str      x21, [x19, #0x158]
007370814  ldr      x10, [x21]
007370818  ldrb     w11, [x10, #0x130]
00737081C  cmp      w11, w8
007370820  b.lo     #0x7371570
007370824  ldr      x8, [x10, #0xc8]
007370828  ldr      x8, [x8, x9, lsl #3]
00737082C  cmp      x8, x1
007370830  b.ne     #0x7371570
007370834  add      x20, x19, #0x158
007370838  b        #0x737087c ;
00737083C  ldr      x3, [x2, #0x60]
007370840  mov      x0, x19
007370844  mov      x1, x21
007370848  ldp      x20, x19, [sp, #0x90]
00737084C  ldp      x22, x21, [sp, #0x80]
007370850  ldp      x24, x23, [sp, #0x70]
007370854  ldp      x26, x25, [sp, #0x60]
007370858  ldp      x28, x27, [sp, #0x50]
00737085C  ldp      x29, x30, [sp, #0x40]
007370860  ldp      d9, d8, [sp, #0x30]
007370864  ldp      d11, d10, [sp, #0x20]
007370868  ldp      d13, d12, [sp, #0x10]
00737086C  add      sp, sp, #0xa0
007370870  br       x3
007370874  add      x20, x19, #0x158
007370878  str      xzr, [x19, #0x158]
00737087C  mov      x0, x20
007370880  mov      x1, x21
007370884  bl       #0x382bcb8 ;
007370888  ldr      x8, [x20]
00737088C  cbz      x8, #0x7371568
007370890  ldrb     w8, [x8, #0x10]
007370894  cbz      w8, #0x73708c0
007370898  adrp     x8, #0x8f92000
00737089C  ldr      x8, [x8, #0xe60]
0073708A0  ldr      x0, [x8]
0073708A4  bl       #0x54ead0c ; HotFix.Singleton<object>$$get_Instance
0073708A8  ldr      x8, [x20]
0073708AC  cbz      x8, #0x7371568
0073708B0  cbz      x0, #0x7371568
0073708B4  ldr      w1, [x8, #0x14]
0073708B8  mov      x2, xzr
0073708BC  bl       #0x7220fc0 ; HotFix.RateAppManager$$OnMainChapterPass
0073708C0  str      wzr, [x19, #0x154]
0073708C4  adrp     x24, #0x8f89000
0073708C8  ldr      x24, [x24, #0xe40]
0073708CC  ldr      x0, [x24]
0073708D0  ldr      w8, [x0, #0xe0]
0073708D4  cbnz     w8, #0x73708dc
0073708D8  bl       #0x382be8c ;
0073708DC  adrp     x21, #0x8f89000
0073708E0  ldr      x21, [x21, #0xe30]
0073708E4  ldr      x0, [x21]
0073708E8  bl       #0x4b69088 ; ListPool<object>$$Get
0073708EC  ldr      x8, [x21]
0073708F0  mov      x21, x0
0073708F4  mov      x0, x8
0073708F8  bl       #0x4b69088 ; ListPool<object>$$Get
0073708FC  ldr      x8, [x20]
007370900  cbz      x8, #0x7371568
007370904  ldr      x23, [x8, #0x40]
007370908  mov      x22, x0
00737090C  cbz      x23, #0x7370a04
007370910  ldr      x8, [x23, #0x18]
007370914  cmp      w8, #1
007370918  str      w8, [x19, #0x154]
00737091C  b.lt     #0x73709b4
007370920  adrp     x27, #0x8f7c000
007370924  ldr      x27, [x27, #0x460]
007370928  mov      x25, xzr
00737092C  and      x8, x8, #0xffffffff
007370930  add      x26, x23, #0x20
007370934  cmp      x25, w8, uxtw
007370938  b.hs     #0x737156c
00737093C  ldr      x0, [x26, x25, lsl #3]
007370940  mov      x1, xzr
007370944  bl       #0x71e1adc ; HotFix.PropDataExpand$$ToPropData
007370948  cbz      x21, #0x7371568
00737094C  ldr      w10, [x21, #0x1c]
007370950  ldr      x8, [x21, #0x10]
007370954  ldr      x9, [x27]
007370958  add      w10, w10, #1
00737095C  str      w10, [x21, #0x1c]
007370960  cbz      x8, #0x7371568
007370964  ldrsw    x10, [x21, #0x18]
007370968  ldr      w11, [x8, #0x18]
00737096C  mov      x1, x0
007370970  cmp      w10, w11
007370974  b.hs     #0x7370990
007370978  add      w9, w10, #1
00737097C  add      x0, x8, x10, lsl #3
007370980  str      w9, [x21, #0x18]
007370984  str      x1, [x0, #0x20]!
007370988  bl       #0x382bcb8 ;
00737098C  b        #0x73709a4 ;
007370990  ldr      x8, [x9, #0x20]
007370994  mov      x0, x21
007370998  ldr      x8, [x8, #0xc0]
00737099C  ldr      x2, [x8, #0x70]
0073709A0  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0073709A4  ldr      w8, [x23, #0x18]
0073709A8  add      x25, x25, #1
0073709AC  cmp      x25, w8, sxtw
0073709B0  b.lt     #0x7370934
0073709B4  adrp     x8, #0x8f86000
0073709B8  ldr      x8, [x8, #0x7a8]
0073709BC  ldr      x0, [x8]
0073709C0  bl       #0x382bfa0 ;
0073709C4  adrp     x8, #0x8f92000
0073709C8  ldr      x8, [x8, #0xe58]
0073709CC  mov      x1, xzr
0073709D0  mov      x3, xzr
0073709D4  mov      x23, x0
0073709D8  ldr      x2, [x8]
0073709DC  bl       #0x5c88294 ; System.Comparison<object>$$.ctor
0073709E0  cbz      x21, #0x7371568
0073709E4  adrp     x8, #0x8f86000
0073709E8  ldr      x8, [x8, #0x7b0]
0073709EC  mov      x0, x21
0073709F0  mov      x1, x23
0073709F4  ldr      x2, [x8]
0073709F8  bl       #0x4db1c5c ; System.Collections.Generic.List<object>$$Sort
0073709FC  ldr      x8, [x20]
007370A00  cbz      x8, #0x7371568
007370A04  ldr      x1, [x8, #0x38]
007370A08  cbz      x1, #0x7370a68
007370A0C  cbz      x22, #0x7371568
007370A10  adrp     x8, #0x8f89000
007370A14  ldr      x8, [x8, #0xe48]
007370A18  mov      x0, x22
007370A1C  ldr      x2, [x8]
007370A20  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
007370A24  adrp     x8, #0x8f86000
007370A28  ldr      x8, [x8, #0x7a8]
007370A2C  ldr      x0, [x8]
007370A30  bl       #0x382bfa0 ;
007370A34  adrp     x8, #0x8f92000
007370A38  ldr      x8, [x8, #0xe58]
007370A3C  mov      x1, xzr
007370A40  mov      x3, xzr
007370A44  mov      x23, x0
007370A48  ldr      x2, [x8]
007370A4C  bl       #0x5c88294 ; System.Comparison<object>$$.ctor
007370A50  adrp     x8, #0x8f86000
007370A54  ldr      x8, [x8, #0x7b0]
007370A58  mov      x0, x22
007370A5C  mov      x1, x23
007370A60  ldr      x2, [x8]
007370A64  bl       #0x4db1c5c ; System.Collections.Generic.List<object>$$Sort
007370A68  ldr      x0, [x19, #0x90]
007370A6C  cbz      x0, #0x7371568
007370A70  adrp     x23, #0x8f89000
007370A74  ldr      x23, [x23, #0xe48]
007370A78  mov      x1, x21
007370A7C  ldr      x2, [x23]
007370A80  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
007370A84  ldr      x0, [x19, #0x90]
007370A88  cbz      x0, #0x7371568
007370A8C  ldr      x2, [x23]
007370A90  mov      x1, x22
007370A94  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
007370A98  ldr      x0, [x24]
007370A9C  ldr      w8, [x0, #0xe0]
007370AA0  cbnz     w8, #0x7370aa8
007370AA4  bl       #0x382be8c ;
007370AA8  adrp     x23, #0x8f89000
007370AAC  ldr      x23, [x23, #0xe38]
007370AB0  mov      x0, x21
007370AB4  ldr      x1, [x23]
007370AB8  bl       #0x4b6913c ; ListPool<object>$$Release
007370ABC  ldr      x1, [x23]
007370AC0  mov      x0, x22
007370AC4  bl       #0x4b6913c ; ListPool<object>$$Release
007370AC8  adrp     x8, #0x8ee6000
007370ACC  ldr      x8, [x8, #0x680]
007370AD0  ldr      x0, [x8]
007370AD4  ldr      w8, [x0, #0xe0]
007370AD8  cbnz     w8, #0x7370ae0
007370ADC  bl       #0x382be8c ;
007370AE0  mov      x0, xzr
007370AE4  bl       #0x7091c90 ; HotFix.Game$$get_Table
007370AE8  ldr      x8, [x20]
007370AEC  cbz      x8, #0x7371568
007370AF0  ldr      w2, [x8, #0x14]
007370AF4  mov      w1, #1
007370AF8  mov      w3, wzr
007370AFC  mov      x4, xzr
007370B00  bl       #0x6b3662c ; HotFix.TableExtension$$GetChapterData
007370B04  cbz      x0, #0x7371568
007370B08  adrp     x10, #0x8f08000
007370B0C  ldr      x8, [x0]
007370B10  ldr      x10, [x10, #0x40]
007370B14  mov      x21, x0
007370B18  ldrh     w9, [x8, #0x12e]
007370B1C  ldr      x1, [x10]
007370B20  cbz      x9, #0x7370b44
007370B24  ldr      x10, [x8, #0xb0]
007370B28  add      x10, x10, #8
007370B2C  ldur     x11, [x10, #-8]
007370B30  cmp      x11, x1
007370B34  b.eq     #0x7370b54
007370B38  subs     x9, x9, #1
007370B3C  add      x10, x10, #0x10
007370B40  b.ne     #0x7370b2c
007370B44  mov      w2, #1
007370B48  mov      x0, x21
007370B4C  bl       #0x3a7e710 ;
007370B50  b        #0x7370b64 ;
007370B54  ldr      w9, [x10]
007370B58  add      w9, w9, #1
007370B5C  add      x8, x8, w9, sxtw #4
007370B60  add      x0, x8, #0x138
007370B64  ldp      x8, x1, [x0]
007370B68  mov      x0, x21
007370B6C  blr      x8
007370B70  ldr      x8, [x20]
007370B74  cbz      x8, #0x7371568
007370B78  ldrb     w1, [x8, #0x10]
007370B7C  mov      w22, w0
007370B80  mov      x0, x19
007370B84  bl       #0x736b3f4 ; HotFix.BaseResulViewModule$$ShowSuccess
007370B88  adrp     x26, #0x8ec2000
007370B8C  ldr      x23, [x19, #0xc0]
007370B90  ldr      x26, [x26, #0xbc8]
007370B94  mov      w1, #1
007370B98  ldr      x0, [x26]
007370B9C  bl       #0x382bdfc ;
007370BA0  ldr      x8, [x19, #0x158]
007370BA4  cbz      x8, #0x7371568
007370BA8  adrp     x9, #0x8ebf000
007370BAC  ldr      w8, [x8, #0x14]
007370BB0  ldr      x9, [x9, #0xba0]
007370BB4  mov      x24, x0
007370BB8  add      x1, sp, #0xc
007370BBC  str      w8, [sp, #0xc]
007370BC0  ldr      x0, [x9]
007370BC4  bl       #0x382be94 ;
007370BC8  cbz      x24, #0x7371568
007370BCC  mov      x25, x0
007370BD0  cbz      x0, #0x7370be8
007370BD4  ldr      x8, [x24]
007370BD8  mov      x0, x25
007370BDC  ldr      x1, [x8, #0x40]
007370BE0  bl       #0x382be90 ;
007370BE4  cbz      x0, #0x7371578
007370BE8  ldr      w8, [x24, #0x18]
007370BEC  cbz      w8, #0x737156c
007370BF0  mov      x0, x24
007370BF4  str      x25, [x0, #0x20]!
007370BF8  mov      x1, x25
007370BFC  bl       #0x382bcb8 ;
007370C00  cbz      x23, #0x7371568
007370C04  adrp     x8, #0x8f92000
007370C08  ldr      x8, [x8, #0xe98]
007370C0C  mov      x0, x23
007370C10  mov      x2, x24
007370C14  mov      x3, xzr
007370C18  ldr      x1, [x8]
007370C1C  bl       #0x41894f4 ; Framework.Logic.UI.CustomText$$SetText
007370C20  ldr      x8, [x19, #0x158]
007370C24  cbz      x8, #0x7371568
007370C28  adrp     x9, #0x8f92000
007370C2C  ldr      x9, [x9, #0xe68]
007370C30  ldr      x23, [x19, #0x60]
007370C34  ldr      w24, [x8, #0x1c]
007370C38  ldr      x0, [x9]
007370C3C  ldr      w9, [x0, #0xe0]
007370C40  cbnz     w9, #0x7370c48
007370C44  bl       #0x382be8c ;
007370C48  mov      w0, w22
007370C4C  mov      w1, w24
007370C50  mov      x2, xzr
007370C54  bl       #0x77942b0 ; HotFix.UIBattleUtil$$GetWaveString
007370C58  cbz      x23, #0x7371568
007370C5C  ldr      x8, [x23]
007370C60  mov      x1, x0
007370C64  mov      x0, x23
007370C68  ldr      x9, [x8, #0x5e8]
007370C6C  ldr      x2, [x8, #0x5f0]
007370C70  blr      x9
007370C74  ldr      x8, [x19, #0x158]
007370C78  cbz      x8, #0x7371568
007370C7C  ldr      x0, [x19, #0x60]
007370C80  cbz      x0, #0x7371568
007370C84  ldrb     w8, [x8, #0x10]
007370C88  ldr      x9, [x0]
007370C8C  adrp     x10, #0x197f000
007370C90  adrp     x11, #0x197f000
007370C94  cmp      w8, #0
007370C98  add      x10, x10, #0x6c0
007370C9C  add      x11, x11, #0xc00
007370CA0  cset     w12, eq
007370CA4  ldr      x8, [x9, #0x2a8]
007370CA8  ldr      s1, [x10, w12, uxtw #2]
007370CAC  ldr      s2, [x11, w12, uxtw #2]
007370CB0  ldr      x1, [x9, #0x2b0]
007370CB4  fmov     s0, #1.00000000
007370CB8  fmov     s3, #1.00000000
007370CBC  blr      x8
007370CC0  adrp     x8, #0x8efd000
007370CC4  ldr      x8, [x8, #0x3b0]
007370CC8  ldr      x9, [x21]
007370CCC  ldr      x8, [x8]
007370CD0  ldrb     w11, [x9, #0x130]
007370CD4  ldrb     w10, [x8, #0x130]
007370CD8  cmp      w11, w10
007370CDC  b.lo     #0x7370cf4
007370CE0  ldr      x9, [x9, #0xc8]
007370CE4  add      x9, x9, x10, lsl #3
007370CE8  ldur     x9, [x9, #-8]
007370CEC  cmp      x9, x8
007370CF0  b.eq     #0x73711ec
007370CF4  ldr      x0, [x19, #0x88]
007370CF8  cbz      x0, #0x7371568
007370CFC  mov      x1, xzr
007370D00  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007370D04  adrp     x8, #0x8ee6000
007370D08  ldr      x8, [x8, #0x88]
007370D0C  mov      x23, x0
007370D10  ldr      x8, [x8]
007370D14  ldr      w9, [x8, #0xe0]
007370D18  cbnz     w9, #0x7370d24
007370D1C  mov      x0, x8
007370D20  bl       #0x382be8c ;
007370D24  mov      x0, x23
007370D28  mov      w1, wzr
007370D2C  mov      x2, xzr
007370D30  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007370D34  ldr      x8, [x20]
007370D38  cbz      x8, #0x7371568
007370D3C  ldrb     w8, [x8, #0x21]
007370D40  cbz      w8, #0x7370e20
007370D44  ldr      x0, [x19, #0x88]
007370D48  cbz      x0, #0x7371568
007370D4C  mov      x1, xzr
007370D50  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007370D54  adrp     x8, #0x8ee6000
007370D58  ldr      x8, [x8, #0x88]
007370D5C  mov      x23, x0
007370D60  ldr      x8, [x8]
007370D64  ldr      w9, [x8, #0xe0]
007370D68  cbnz     w9, #0x7370d74
007370D6C  mov      x0, x8
007370D70  bl       #0x382be8c ;
007370D74  mov      x0, x23
007370D78  mov      w1, wzr
007370D7C  mov      x2, xzr
007370D80  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007370D84  ldr      x8, [x20]
007370D88  cbz      x8, #0x7371568
007370D8C  ldr      w8, [x8, #0x48]
007370D90  cbz      w8, #0x7370ddc
007370D94  adrp     x24, #0x8f92000
007370D98  ldr      x24, [x24, #0xe80]
007370D9C  mov      x23, xzr
007370DA0  ldr      x8, [x19, #0xe8]
007370DA4  cbz      x8, #0x7371568
007370DA8  ldr      w9, [x8, #0x18]
007370DAC  cmp      x23, x9
007370DB0  b.hs     #0x737156c
007370DB4  add      x8, x8, x23, lsl #3
007370DB8  ldr      x0, [x8, #0x20]
007370DBC  cbz      x0, #0x7371568
007370DC0  ldr      x1, [x24]
007370DC4  mov      x2, xzr
007370DC8  bl       #0x75ac51c ; HotFix.MapStar$$SetImage
007370DCC  add      x23, x23, #1
007370DD0  cmp      x23, #3
007370DD4  b.ne     #0x7370da0
007370DD8  b        #0x7370e20 ;
007370DDC  adrp     x24, #0x8f92000
007370DE0  ldr      x24, [x24, #0xea0]
007370DE4  mov      x23, xzr
007370DE8  ldr      x8, [x19, #0xe8]
007370DEC  cbz      x8, #0x7371568
007370DF0  ldr      w9, [x8, #0x18]
007370DF4  cmp      x23, x9
007370DF8  b.hs     #0x737156c
007370DFC  add      x8, x8, x23, lsl #3
007370E00  ldr      x0, [x8, #0x20]
007370E04  cbz      x0, #0x7371568
007370E08  ldr      x1, [x24]
007370E0C  mov      x2, xzr
007370E10  bl       #0x75ac51c ; HotFix.MapStar$$SetImage
007370E14  add      x23, x23, #1
007370E18  cmp      x23, #3
007370E1C  b.ne     #0x7370de8
007370E20  mov      x0, x19
007370E24  mov      w1, w22
007370E28  bl       #0x736b548 ; HotFix.BaseResulViewModule$$SetReachLevelByChapterType
007370E2C  adrp     x8, #0x8ec3000
007370E30  ldr      x8, [x8, #0xdc0]
007370E34  ldr      x22, [x19, #0xc8]
007370E38  ldr      x23, [x8]
007370E3C  ldr      x8, [x23, #0x38]
007370E40  cbnz     x8, #0x7370e50
007370E44  mov      x0, x23
007370E48  bl       #0x3a7e668 ;
007370E4C  ldr      x8, [x23, #0x38]
007370E50  ldr      x0, [x8, #0x10]
007370E54  ldrb     w8, [x0, #0x135]
007370E58  tbnz     w8, #0, #0x7370e60
007370E5C  bl       #0x3a7e60c ;
007370E60  ldr      w8, [x0, #0xe0]
007370E64  cbnz     w8, #0x7370e6c
007370E68  bl       #0x382be8c ;
007370E6C  ldr      x8, [x23, #0x38]
007370E70  ldr      x0, [x8, #0x10]
007370E74  ldrb     w8, [x0, #0x135]
007370E78  tbnz     w8, #0, #0x7370e80
007370E7C  bl       #0x3a7e60c ;
007370E80  cbz      x22, #0x7371568
007370E84  adrp     x9, #0x8f92000
007370E88  ldr      x8, [x0, #0xb8]
007370E8C  ldr      x9, [x9, #0xe78]
007370E90  mov      x0, x22
007370E94  mov      x3, xzr
007370E98  ldr      x2, [x8]
007370E9C  ldr      x1, [x9]
007370EA0  bl       #0x41894f4 ; Framework.Logic.UI.CustomText$$SetText
007370EA4  ldr      x0, [x19, #0xc8]
007370EA8  cbz      x0, #0x7371568
007370EAC  mov      x1, xzr
007370EB0  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007370EB4  ldr      x8, [x20]
007370EB8  cbz      x8, #0x7371568
007370EBC  adrp     x23, #0x8ee6000
007370EC0  ldr      x23, [x23, #0x88]
007370EC4  mov      x22, x0
007370EC8  ldrb     w24, [x8, #0x20]
007370ECC  ldr      x0, [x23]
007370ED0  ldr      w9, [x0, #0xe0]
007370ED4  cbnz     w9, #0x7370edc
007370ED8  bl       #0x382be8c ;
007370EDC  cmp      w24, #0
007370EE0  cset     w1, ne
007370EE4  mov      x0, x22
007370EE8  mov      x2, xzr
007370EEC  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007370EF0  ldr      x8, [x20]
007370EF4  cbz      x8, #0x7371568
007370EF8  adrp     x24, #0x8ee8000
007370EFC  ldr      x24, [x24, #0x898]
007370F00  ldr      w22, [x8, #0x14]
007370F04  ldr      x0, [x24]
007370F08  ldr      w9, [x0, #0xe0]
007370F0C  cbnz     w9, #0x7370f18
007370F10  bl       #0x382be8c ;
007370F14  ldr      x0, [x24]
007370F18  ldr      x8, [x0, #0xb8]
007370F1C  ldr      w8, [x8, #0x280]
007370F20  cmp      w22, w8
007370F24  b.ne     #0x7370f48
007370F28  ldr      x8, [x20]
007370F2C  cbz      x8, #0x7371568
007370F30  ldrb     w9, [x8, #0x10]
007370F34  cbz      w9, #0x7370f48
007370F38  ldrb     w8, [x8, #0x20]
007370F3C  cmp      w8, #0
007370F40  cset     w8, ne
007370F44  b        #0x7370f4c ;
007370F48  mov      w8, wzr
007370F4C  ldr      x0, [x19, #0xe0]
007370F50  strb     w8, [x19, #0x160]
007370F54  cbz      x0, #0x7371568
007370F58  fmov     s0, wzr
007370F5C  mov      x1, xzr
007370F60  bl       #0x897d2d8 ; UnityEngine.CanvasGroup$$set_alpha
007370F64  mov      x0, x19
007370F68  bl       #0x7371584 ; HotFix.BattleResultViewMainModule$$playStarAnim
007370F6C  ldr      x8, [x19, #0x158]
007370F70  cbz      x8, #0x7371568
007370F74  ldrb     w9, [x8, #0x21]
007370F78  cbz      w9, #0x7370f8c
007370F7C  ldrb     w8, [x8, #0x10]
007370F80  cmp      w8, #0
007370F84  cset     w22, ne
007370F88  b        #0x7370f90 ;
007370F8C  mov      w22, wzr
007370F90  ldr      x0, [x19, #0xf0]
007370F94  cbz      x0, #0x7371568
007370F98  mov      x1, xzr
007370F9C  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007370FA0  ldr      x8, [x23]
007370FA4  mov      x23, x0
007370FA8  ldr      w9, [x8, #0xe0]
007370FAC  cbnz     w9, #0x7370fb8
007370FB0  mov      x0, x8
007370FB4  bl       #0x382be8c ;
007370FB8  mov      x0, x23
007370FBC  mov      w1, w22
007370FC0  mov      x2, xzr
007370FC4  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007370FC8  cbz      w22, #0x7371098
007370FCC  adrp     x8, #0x8ef8000
007370FD0  ldr      x22, [x19, #0xf0]
007370FD4  ldr      x8, [x8, #0x30]
007370FD8  ldr      x0, [x8]
007370FDC  bl       #0x54ead0c ; HotFix.Singleton<object>$$get_Instance
007370FE0  cbz      x0, #0x7371568
007370FE4  adrp     x8, #0x8f92000
007370FE8  ldr      x8, [x8, #0xe88]
007370FEC  mov      x2, xzr
007370FF0  ldr      x1, [x8]
007370FF4  bl       #0x7304360 ; HotFix.LanguageManager$$GetInfoByID
007370FF8  ldr      x8, [x20]
007370FFC  cbz      x8, #0x7371568
007371000  mov      x20, x0
007371004  ldr      w0, [x8, #0x2c]
007371008  mov      x1, xzr
00737100C  bl       #0x77ff128 ; HotFix.UITimeStr$$GetRankTime
007371010  mov      x1, x0
007371014  mov      x0, x20
007371018  mov      x2, xzr
00737101C  bl       #0x79d469c ; System.String$$Concat
007371020  cbz      x22, #0x7371568
007371024  ldr      x8, [x22]
007371028  mov      x1, x0
00737102C  mov      x0, x22
007371030  ldr      x9, [x8, #0x5e8]
007371034  ldr      x2, [x8, #0x5f0]
007371038  blr      x9
00737103C  ldr      x0, [x19, #0xf0]
007371040  cbz      x0, #0x7371568
007371044  mov      x1, xzr
007371048  bl       #0x874a824 ; UnityEngine.Component$$get_transform
00737104C  adrp     x22, #0x958e000
007371050  ldrb     w8, [x22, #0xa1]
007371054  mov      x20, x0
007371058  cbnz     w8, #0x7371070
00737105C  adrp     x0, #0x8ebf000
007371060  ldr      x0, [x0, #0x458]
007371064  bl       #0x382bd14 ;
007371068  mov      w8, #1
00737106C  strb     w8, [x22, #0xa1]
007371070  cbz      x20, #0x7371568
007371074  adrp     x8, #0x8ebf000
007371078  ldr      x8, [x8, #0x458]
00737107C  mov      x0, x20
007371080  mov      x1, xzr
007371084  ldr      x8, [x8]
007371088  ldr      x8, [x8, #0xb8]
00737108C  ldp      s1, s2, [x8, #4]
007371090  ldr      s0, [x8]
007371094  bl       #0x875ca48 ; UnityEngine.Transform$$set_localScale
007371098  ldr      x8, [x19, #0x158]
00737109C  cbz      x8, #0x7371568
0073710A0  ldr      x20, [x19, #0x108]
0073710A4  add      x0, x8, #0x24
0073710A8  mov      x1, xzr
0073710AC  bl       #0x7bd22a0 ; System.Int32$$ToString
0073710B0  cbz      x20, #0x7371568
0073710B4  ldr      x8, [x20]
0073710B8  mov      x1, x0
0073710BC  mov      x0, x20
0073710C0  ldr      x9, [x8, #0x5e8]
0073710C4  ldr      x2, [x8, #0x5f0]
0073710C8  blr      x9
0073710CC  ldr      x8, [x19, #0x158]
0073710D0  cbz      x8, #0x7371568
0073710D4  ldr      x20, [x19, #0x100]
0073710D8  add      x0, x8, #0x28
0073710DC  mov      x1, xzr
0073710E0  bl       #0x7bd22a0 ; System.Int32$$ToString
0073710E4  cbz      x20, #0x7371568
0073710E8  ldr      x8, [x20]
0073710EC  mov      x1, x0
0073710F0  mov      x0, x20
0073710F4  ldr      x9, [x8, #0x5e8]
0073710F8  ldr      x2, [x8, #0x5f0]
0073710FC  blr      x9
007371100  mov      x0, x19
007371104  mov      x1, x21
007371108  bl       #0x7371954 ; HotFix.BattleResultViewMainModule$$ShowRecommendSkills
00737110C  ldr      x8, [x19, #0x158]
007371110  cbz      x8, #0x7371568
007371114  adrp     x22, #0x8f92000
007371118  ldr      x22, [x22, #0xe50]
00737111C  ldr      x20, [x19, #0x38]
007371120  ldrb     w21, [x8, #0x10]
007371124  ldr      x0, [x22]
007371128  ldr      w9, [x0, #0xe0]
00737112C  cbnz     w9, #0x7371138
007371130  bl       #0x382be8c ;
007371134  ldr      x0, [x22]
007371138  cbz      x20, #0x7371568
00737113C  ldr      x8, [x0, #0xb8]
007371140  cmp      w21, #0
007371144  mov      x0, x20
007371148  mov      x2, xzr
00737114C  add      x9, x8, #4
007371150  csel     x8, x9, x8, eq
007371154  ldr      w1, [x8]
007371158  bl       #0x86d3960 ; UnityEngine.Animator$$SetTrigger
00737115C  ldr      x8, [x19, #0x158]
007371160  cbz      x8, #0x7371568
007371164  ldr      x0, [x19, #0x38]
007371168  cbz      x0, #0x7371568
00737116C  ldrb     w2, [x8, #0x20]
007371170  adrp     x8, #0x8f92000
007371174  ldr      x8, [x8, #0xe90]
007371178  mov      x3, xzr
00737117C  ldr      x1, [x8]
007371180  bl       #0x86d3528 ; UnityEngine.Animator$$SetBool
007371184  ldr      x8, [x19, #0x90]
007371188  ldr      x0, [x19, #0x38]
00737118C  cbz      x8, #0x73711a4
007371190  ldr      w8, [x8, #0x18]
007371194  cmp      w8, #0
007371198  cset     w2, gt
00737119C  cbnz     x0, #0x73711ac
0073711A0  b        #0x7371568 ;
0073711A4  mov      w2, wzr
0073711A8  cbz      x0, #0x7371568
0073711AC  adrp     x8, #0x8f57000
0073711B0  ldr      x8, [x8, #0xd70]
0073711B4  mov      x3, xzr
0073711B8  ldr      x1, [x8]
0073711BC  bl       #0x86d3528 ; UnityEngine.Animator$$SetBool
0073711C0  ldp      x20, x19, [sp, #0x90]
0073711C4  ldp      x22, x21, [sp, #0x80]
0073711C8  ldp      x24, x23, [sp, #0x70]
0073711CC  ldp      x26, x25, [sp, #0x60]
0073711D0  ldp      x28, x27, [sp, #0x50]
0073711D4  ldp      x29, x30, [sp, #0x40]
0073711D8  ldp      d9, d8, [sp, #0x30]
0073711DC  ldp      d11, d10, [sp, #0x20]
0073711E0  ldp      d13, d12, [sp, #0x10]
0073711E4  add      sp, sp, #0xa0
0073711E8  ret
0073711EC  ldr      x8, [x20]
0073711F0  cbz      x8, #0x7371568
0073711F4  adrp     x27, #0x95a7000
0073711F8  ldrb     w9, [x27, #0xa63]
0073711FC  ldr      w25, [x8, #0x18]
007371200  cbnz     w9, #0x7371218
007371204  adrp     x0, #0x8f26000
007371208  ldr      x0, [x0, #0xda8]
00737120C  bl       #0x382bd14 ;
007371210  mov      w8, #1
007371214  strb     w8, [x27, #0xa63]
007371218  adrp     x28, #0x8f26000
00737121C  ldr      x28, [x28, #0xda8]
007371220  ldr      x1, [x28]
007371224  ldrb     w8, [x1, #0x53]
007371228  tbnz     w8, #5, #0x7371234
00737122C  ldr      w23, [x21, #0x150]
007371230  b        #0x7371244 ;
007371234  ldr      x8, [x1, #0x60]
007371238  mov      x0, x21
00737123C  blr      x8
007371240  mov      w23, w0
007371244  adrp     x24, #0x8ee1000
007371248  ldr      x24, [x24, #0x5e0]
00737124C  ldr      x0, [x24]
007371250  ldr      w8, [x0, #0xe0]
007371254  cbnz     w8, #0x737125c
007371258  bl       #0x382be8c ;
00737125C  adrp     x29, #0x9597000
007371260  ldrb     w8, [x29, #0xec6]
007371264  cbnz     w8, #0x737127c
007371268  adrp     x0, #0x8ee1000
00737126C  ldr      x0, [x0, #0x5e0]
007371270  bl       #0x382bd14 ;
007371274  mov      w8, #1
007371278  strb     w8, [x29, #0xec6]
00737127C  ldr      x0, [x24]
007371280  ldr      w8, [x0, #0xe0]
007371284  cbnz     w8, #0x7371290
007371288  bl       #0x382be8c ;
00737128C  ldr      x0, [x24]
007371290  ldr      x8, [x0, #0xb8]
007371294  mov      x1, xzr
007371298  ldr      x0, [x8, #0x38]
00737129C  bl       #0x725cac8 ; HotFix.FrameworkExpand$$GetManager
0073712A0  adrp     x29, #0x9598000
0073712A4  ldrb     w8, [x29, #0xcb1]
0073712A8  mov      x24, x0
0073712AC  cbnz     w8, #0x73712c4
0073712B0  adrp     x0, #0x8efd000
0073712B4  ldr      x0, [x0, #0x3c0]
0073712B8  bl       #0x382bd14 ;
0073712BC  mov      w8, #1
0073712C0  strb     w8, [x29, #0xcb1]
0073712C4  adrp     x8, #0x8efd000
0073712C8  ldr      x8, [x8, #0x3c0]
0073712CC  ldr      x1, [x8]
0073712D0  ldrb     w8, [x1, #0x53]
0073712D4  tbnz     w8, #5, #0x73712e0
0073712D8  ldr      w0, [x21, #0x20]
0073712DC  b        #0x73712ec ;
0073712E0  ldr      x8, [x1, #0x60]
0073712E4  mov      x0, x21
0073712E8  blr      x8
0073712EC  cbz      x24, #0x7371568
0073712F0  add      w1, w0, #1
0073712F4  mov      x0, x24
0073712F8  mov      x2, xzr
0073712FC  bl       #0x64e3b1c ; LocalModels.LocalModelManager$$GetChapter_MainChapter
007371300  cbz      x0, #0x7371338
007371304  ldrb     w8, [x27, #0xa63]
007371308  mov      x24, x0
00737130C  cbnz     w8, #0x7371324
007371310  adrp     x0, #0x8f26000
007371314  ldr      x0, [x0, #0xda8]
007371318  bl       #0x382bd14 ;
00737131C  mov      w8, #1
007371320  strb     w8, [x27, #0xa63]
007371324  ldr      x1, [x28]
007371328  ldrb     w8, [x1, #0x53]
00737132C  tbnz     w8, #5, #0x7371340
007371330  ldr      w0, [x24, #0x150]
007371334  b        #0x737134c ;
007371338  mov      w0, #0x64
00737133C  b        #0x737134c ;
007371340  ldr      x8, [x1, #0x60]
007371344  mov      x0, x24
007371348  blr      x8
00737134C  scvtf    s0, w25
007371350  fmov     s8, #1.50000000
007371354  sub      w8, w0, w23
007371358  fmul     s0, s0, s8
00737135C  fmov     s1, #4.00000000
007371360  scvtf    s9, w8
007371364  bl       #0x89edac0 ;
007371368  adrp     x8, #0x197e000
00737136C  ldr      s11, [x8, #0xf7c]
007371370  add      w8, w25, #1
007371374  scvtf    s10, w23
007371378  scvtf    s1, w8
00737137C  fadd     s2, s0, s11
007371380  fdiv     s0, s0, s2
007371384  fmul     s0, s0, s9
007371388  fadd     s12, s0, s10
00737138C  fmul     s0, s1, s8
007371390  fmov     s1, #4.00000000
007371394  bl       #0x89edac0 ;
007371398  adrp     x8, #0x8ec3000
00737139C  ldr      x8, [x8, #0xf70]
0073713A0  mov      v8.16b, v0.16b
0073713A4  ldr      x0, [x8]
0073713A8  bl       #0x382bfa0 ;
0073713AC  mov      x1, xzr
0073713B0  mov      x23, x0
0073713B4  bl       #0x7be7998 ; System.Random$$.ctor
0073713B8  adrp     x25, #0x9591000
0073713BC  ldrb     w8, [x25, #0x13c]
0073713C0  mov      w9, #0x42c80000
0073713C4  fmov     s13, w9
0073713C8  cbnz     w8, #0x73713e0
0073713CC  adrp     x0, #0x8ebf000
0073713D0  ldr      x0, [x0, #0x840]
0073713D4  bl       #0x382bd14 ;
0073713D8  mov      w8, #1
0073713DC  strb     w8, [x25, #0x13c]
0073713E0  adrp     x27, #0x8ebf000
0073713E4  ldr      x27, [x27, #0x840]
0073713E8  fmul     s12, s12, s13
0073713EC  ldr      x0, [x27]
0073713F0  ldr      w8, [x0, #0xe0]
0073713F4  cbz      w8, #0x7371400
0073713F8  mov      w8, #1
0073713FC  b        #0x7371408 ;
007371400  bl       #0x382be8c ;
007371404  ldrb     w8, [x25, #0x13c]
007371408  mov      w9, #0x7f800000
00737140C  frintp   s0, s12
007371410  fmov     s1, w9
007371414  fcvtps   w10, s12
007371418  fcmp     s0, s1
00737141C  mov      w9, #-0x80000000
007371420  csel     w24, w9, w10, eq
007371424  cbnz     w8, #0x737143c
007371428  adrp     x0, #0x8ebf000
00737142C  ldr      x0, [x0, #0x840]
007371430  bl       #0x382bd14 ;
007371434  mov      w8, #1
007371438  strb     w8, [x25, #0x13c]
00737143C  ldr      x0, [x27]
007371440  ldr      w8, [x0, #0xe0]
007371444  cbnz     w8, #0x737144c
007371448  bl       #0x382be8c ;
00737144C  cbz      x23, #0x7371568
007371450  fadd     s0, s8, s11
007371454  ldr      x10, [x23]
007371458  fdiv     s0, s8, s0
00737145C  mov      w8, #0x42c80000
007371460  fmul     s0, s0, s9
007371464  fmov     s1, w8
007371468  fadd     s0, s0, s10
00737146C  mov      w9, #0x7f800000
007371470  fmul     s0, s0, s1
007371474  ldp      x8, x3, [x10, #0x198]
007371478  fmov     s2, w9
00737147C  frintp   s0, s0
007371480  fcvtzs   w9, s0
007371484  fcmp     s0, s2
007371488  mov      w10, #-0x80000000
00737148C  csel     w2, w10, w9, eq
007371490  mov      x0, x23
007371494  mov      w1, w24
007371498  blr      x8
00737149C  ldr      x8, [x26]
0073714A0  ldr      x23, [x19, #0x88]
0073714A4  mov      w25, w0
0073714A8  mov      w1, #1
0073714AC  mov      x0, x8
0073714B0  bl       #0x382bdfc ;
0073714B4  adrp     x9, #0x8ec0000
0073714B8  ldr      x9, [x9, #0xc40]
0073714BC  mov      x24, x0
0073714C0  mov      w8, #0x42c80000
0073714C4  scvtf    s0, w25
0073714C8  ldr      x0, [x9]
0073714CC  fmov     s1, w8
0073714D0  fdiv     s0, s0, s1
0073714D4  add      x1, sp, #8
0073714D8  str      s0, [sp, #8]
0073714DC  bl       #0x382be94 ;
0073714E0  cbz      x24, #0x7371568
0073714E4  mov      x25, x0
0073714E8  cbz      x0, #0x7371500
0073714EC  ldr      x8, [x24]
0073714F0  mov      x0, x25
0073714F4  ldr      x1, [x8, #0x40]
0073714F8  bl       #0x382be90 ;
0073714FC  cbz      x0, #0x7371578
007371500  ldr      w8, [x24, #0x18]
007371504  cbz      w8, #0x737156c
007371508  mov      x0, x24
00737150C  str      x25, [x0, #0x20]!
007371510  mov      x1, x25
007371514  bl       #0x382bcb8 ;
007371518  adrp     x8, #0x8eeb000
00737151C  ldr      x8, [x8, #0xcf8]
007371520  ldr      x0, [x8]
007371524  ldr      w8, [x0, #0xe0]
007371528  cbnz     w8, #0x7371530
00737152C  bl       #0x382be8c ;
007371530  adrp     x8, #0x8f92000
007371534  ldr      x8, [x8, #0xe70]
007371538  mov      x1, x24
00737153C  mov      x2, xzr
007371540  ldr      x0, [x8]
007371544  bl       #0x77cc470 ; HotFix.GameExtension$$GetLanguageByTID
007371548  cbz      x23, #0x7371568
00737154C  ldr      x8, [x23]
007371550  mov      x1, x0
007371554  mov      x0, x23
007371558  ldr      x9, [x8, #0x5e8]
00737155C  ldr      x2, [x8, #0x5f0]
007371560  blr      x9
007371564  b        #0x7370d34 ;
007371568  bl       #0x382bfb8 ;
00737156C  bl       #0x382bfc0 ;
007371570  mov      x0, x21
007371574  bl       #0x382c354 ;
007371578  bl       #0x382bfdc ;
00737157C  mov      x1, xzr
007371580  bl       #0x382be7c ;

; HotFix.BattleResultViewMainModule$$playStarAnim
; RVA 0x7371584; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007371584  stp      d9, d8, [sp, #-0x40]!
007371588  str      x30, [sp, #0x10]
00737158C  stp      x22, x21, [sp, #0x20]
007371590  stp      x20, x19, [sp, #0x30]
007371594  adrp     x20, #0x95a7000
007371598  adrp     x21, #0x8f92000
00737159C  ldrb     w8, [x20, #0xa36]
0073715A0  ldr      x21, [x21, #0xea8]
0073715A4  mov      x19, x0
0073715A8  tbnz     w8, #0, #0x73715fc
0073715AC  adrp     x0, #0x8f92000
0073715B0  ldr      x0, [x0, #0xea8]
0073715B4  bl       #0x382bd14 ;
0073715B8  adrp     x0, #0x8f92000
0073715BC  ldr      x0, [x0, #0xeb0]
0073715C0  bl       #0x382bd14 ;
0073715C4  adrp     x0, #0x8ef8000
0073715C8  ldr      x0, [x0, #0x1a8]
0073715CC  bl       #0x382bd14 ;
0073715D0  adrp     x0, #0x8ee1000
0073715D4  ldr      x0, [x0, #0x5e0]
0073715D8  bl       #0x382bd14 ;
0073715DC  adrp     x0, #0x8ef8000
0073715E0  ldr      x0, [x0, #0xba0]
0073715E4  bl       #0x382bd14 ;
0073715E8  adrp     x0, #0x8ede000
0073715EC  ldr      x0, [x0, #0x758]
0073715F0  bl       #0x382bd14 ;
0073715F4  mov      w8, #1
0073715F8  strb     w8, [x20, #0xa36]
0073715FC  ldr      x1, [x21]
007371600  ldrb     w8, [x1, #0x53]
007371604  tbnz     w8, #5, #0x73717e4
007371608  adrp     x20, #0x8ee1000
00737160C  ldr      x20, [x20, #0x5e0]
007371610  ldr      x0, [x20]
007371614  ldr      w8, [x0, #0xe0]
007371618  cbnz     w8, #0x7371620
00737161C  bl       #0x382be8c ;
007371620  adrp     x21, #0x9591000
007371624  ldrb     w8, [x21, #0x5bb]
007371628  cbnz     w8, #0x7371640
00737162C  adrp     x0, #0x8ee1000
007371630  ldr      x0, [x0, #0x5e0]
007371634  bl       #0x382bd14 ;
007371638  mov      w8, #1
00737163C  strb     w8, [x21, #0x5bb]
007371640  ldr      x0, [x20]
007371644  adrp     x21, #0x8ef8000
007371648  ldr      w8, [x0, #0xe0]
00737164C  ldr      x21, [x21, #0x1a8]
007371650  cbnz     w8, #0x737165c
007371654  bl       #0x382be8c ;
007371658  ldr      x0, [x20]
00737165C  ldr      x8, [x0, #0xb8]
007371660  ldr      x2, [x21]
007371664  mov      w1, #0x69
007371668  ldr      x0, [x8, #0x18]
00737166C  bl       #0x462beb8 ; HotFix.FrameworkExpand$$GetDataModule<object>
007371670  cbz      x0, #0x737194c
007371674  ldr      x0, [x0, #0xe8]
007371678  cbz      x0, #0x737194c
00737167C  adrp     x8, #0x8f92000
007371680  ldr      x8, [x8, #0xeb0]
007371684  ldr      x1, [x8]
007371688  bl       #0x5d1c684 ; HotFix.DataMessageRecorder<object>$$HasMessage
00737168C  ldr      x8, [x19, #0x158]
007371690  cbz      x8, #0x737194c
007371694  ldrb     w8, [x8, #0x21]
007371698  tbz      w0, #0, #0x7371800
00737169C  cbz      w8, #0x7371938
0073716A0  ldr      x0, [x19, #0xe0]
0073716A4  cbz      x0, #0x737194c
0073716A8  fmov     s0, #1.00000000
0073716AC  mov      x1, xzr
0073716B0  bl       #0x897d2d8 ; UnityEngine.CanvasGroup$$set_alpha
0073716B4  ldr      x8, [x19, #0x158]
0073716B8  cbz      x8, #0x737194c
0073716BC  ldr      w0, [x8, #0x30]
0073716C0  mov      x1, xzr
0073716C4  bl       #0x71accc8 ; HotFix.StarMaskTool$$GetStarCount
0073716C8  cmp      w0, #1
0073716CC  b.lt     #0x7371740
0073716D0  adrp     x8, #0x197e000
0073716D4  adrp     x9, #0x197e000
0073716D8  ldr      s8, [x8, #0xc04]
0073716DC  ldr      s9, [x9, #0xdf8]
0073716E0  mov      w20, w0
0073716E4  mov      w22, wzr
0073716E8  ldr      x8, [x19, #0xe8]
0073716EC  cbz      x8, #0x737194c
0073716F0  ldr      w9, [x8, #0x18]
0073716F4  cmp      w22, w9
0073716F8  b.hs     #0x7371950
0073716FC  ldr      x0, [x19, #0x98]
007371700  cbz      x0, #0x737194c
007371704  add      x8, x8, w22, sxtw #3
007371708  ldr      x21, [x8, #0x20]
00737170C  mov      x1, xzr
007371710  bl       #0x77f02e8 ; HotFix.SequencePool$$Get
007371714  cbz      x21, #0x737194c
007371718  scvtf    s0, w22
00737171C  fmul     s0, s0, s8
007371720  mov      x1, x0
007371724  fadd     s0, s0, s9
007371728  mov      x0, x21
00737172C  mov      x2, xzr
007371730  bl       #0x75ac29c ; HotFix.MapStar$$ShowStar
007371734  add      w22, w22, #1
007371738  cmp      w20, w22
00737173C  b.ne     #0x73716e8
007371740  ldr      x8, [x19, #0x158]
007371744  cbz      x8, #0x737194c
007371748  ldrb     w8, [x8, #0x10]
00737174C  cbz      w8, #0x7371938
007371750  ldr      x0, [x19, #0xf0]
007371754  cbz      x0, #0x737194c
007371758  mov      x1, xzr
00737175C  bl       #0x874a824 ; UnityEngine.Component$$get_transform
007371760  adrp     x20, #0x958e000
007371764  ldrb     w8, [x20, #0x3d5]
007371768  mov      x19, x0
00737176C  cbnz     w8, #0x7371784
007371770  adrp     x0, #0x8ebf000
007371774  ldr      x0, [x0, #0x458]
007371778  bl       #0x382bd14 ;
00737177C  mov      w8, #1
007371780  strb     w8, [x20, #0x3d5]
007371784  adrp     x8, #0x8ebf000
007371788  ldr      x8, [x8, #0x458]
00737178C  fmov     s3, #0.25000000
007371790  mov      x0, x19
007371794  mov      x1, xzr
007371798  ldr      x8, [x8]
00737179C  ldr      x8, [x8, #0xb8]
0073717A0  ldp      s0, s1, [x8, #0xc]
0073717A4  ldr      s2, [x8, #0x14]
0073717A8  bl       #0x40f16e4 ; DG.Tweening.ShortcutExtensions$$DOScale
0073717AC  adrp     x8, #0x8ede000
0073717B0  ldr      x8, [x8, #0x758]
0073717B4  mov      w1, #0x1f
0073717B8  ldr      x2, [x8]
0073717BC  bl       #0x4727cac ; DG.Tweening.TweenSettingsExtensions$$SetEase<object>
0073717C0  adrp     x8, #0x8ef8000
0073717C4  ldr      x8, [x8, #0xba0]
0073717C8  ldp      x20, x19, [sp, #0x30]
0073717CC  ldp      x22, x21, [sp, #0x20]
0073717D0  ldr      x30, [sp, #0x10]
0073717D4  ldr      x1, [x8]
0073717D8  fmov     s0, #1.00000000
0073717DC  ldp      d9, d8, [sp], #0x40
0073717E0  b        #0x4727b44 ; DG.Tweening.TweenSettingsExtensions$$SetDelay<object>
0073717E4  ldr      x2, [x1, #0x60]
0073717E8  mov      x0, x19
0073717EC  ldp      x20, x19, [sp, #0x30]
0073717F0  ldp      x22, x21, [sp, #0x20]
0073717F4  ldr      x30, [sp, #0x10]
0073717F8  ldp      d9, d8, [sp], #0x40
0073717FC  br       x2
007371800  cbz      w8, #0x7371938
007371804  ldr      x0, [x19, #0xe0]
007371808  cbz      x0, #0x737194c
00737180C  fmov     s0, #1.00000000
007371810  mov      x1, xzr
007371814  bl       #0x897d2d8 ; UnityEngine.CanvasGroup$$set_alpha
007371818  ldr      x8, [x19, #0x158]
00737181C  cbz      x8, #0x737194c
007371820  ldrb     w9, [x8, #0x10]
007371824  cbz      w9, #0x73718b4
007371828  ldr      x0, [x19, #0xf0]
00737182C  cbz      x0, #0x737194c
007371830  mov      x1, xzr
007371834  bl       #0x874a824 ; UnityEngine.Component$$get_transform
007371838  adrp     x21, #0x958e000
00737183C  ldrb     w8, [x21, #0x3d5]
007371840  mov      x20, x0
007371844  cbnz     w8, #0x737185c
007371848  adrp     x0, #0x8ebf000
00737184C  ldr      x0, [x0, #0x458]
007371850  bl       #0x382bd14 ;
007371854  mov      w8, #1
007371858  strb     w8, [x21, #0x3d5]
00737185C  adrp     x8, #0x8ebf000
007371860  ldr      x8, [x8, #0x458]
007371864  fmov     s3, #0.25000000
007371868  mov      x0, x20
00737186C  mov      x1, xzr
007371870  ldr      x8, [x8]
007371874  ldr      x8, [x8, #0xb8]
007371878  ldp      s0, s1, [x8, #0xc]
00737187C  ldr      s2, [x8, #0x14]
007371880  bl       #0x40f16e4 ; DG.Tweening.ShortcutExtensions$$DOScale
007371884  adrp     x8, #0x8ede000
007371888  ldr      x8, [x8, #0x758]
00737188C  mov      w1, #0x1f
007371890  ldr      x2, [x8]
007371894  bl       #0x4727cac ; DG.Tweening.TweenSettingsExtensions$$SetEase<object>
007371898  adrp     x8, #0x8ef8000
00737189C  ldr      x8, [x8, #0xba0]
0073718A0  fmov     s0, #0.50000000
0073718A4  ldr      x1, [x8]
0073718A8  bl       #0x4727b44 ; DG.Tweening.TweenSettingsExtensions$$SetDelay<object>
0073718AC  ldr      x8, [x19, #0x158]
0073718B0  cbz      x8, #0x737194c
0073718B4  ldr      w0, [x8, #0x30]
0073718B8  mov      x1, xzr
0073718BC  bl       #0x71accc8 ; HotFix.StarMaskTool$$GetStarCount
0073718C0  cmp      w0, #1
0073718C4  b.lt     #0x7371938
0073718C8  adrp     x8, #0x197f000
0073718CC  adrp     x9, #0x197e000
0073718D0  ldr      s8, [x8, #0x128]
0073718D4  ldr      s9, [x9, #0xe4c]
0073718D8  mov      w20, w0
0073718DC  mov      w22, wzr
0073718E0  ldr      x8, [x19, #0xe8]
0073718E4  cbz      x8, #0x737194c
0073718E8  ldr      w9, [x8, #0x18]
0073718EC  cmp      w22, w9
0073718F0  b.hs     #0x7371950
0073718F4  ldr      x0, [x19, #0x98]
0073718F8  cbz      x0, #0x737194c
0073718FC  add      x8, x8, w22, sxtw #3
007371900  ldr      x21, [x8, #0x20]
007371904  mov      x1, xzr
007371908  bl       #0x77f02e8 ; HotFix.SequencePool$$Get
00737190C  cbz      x21, #0x737194c
007371910  scvtf    s0, w22
007371914  fmul     s0, s0, s8
007371918  mov      x1, x0
00737191C  fadd     s0, s0, s9
007371920  mov      x0, x21
007371924  mov      x2, xzr
007371928  bl       #0x75ac29c ; HotFix.MapStar$$ShowStar
00737192C  add      w22, w22, #1
007371930  cmp      w20, w22
007371934  b.ne     #0x73718e0
007371938  ldp      x20, x19, [sp, #0x30]
00737193C  ldp      x22, x21, [sp, #0x20]
007371940  ldr      x30, [sp, #0x10]
007371944  ldp      d9, d8, [sp], #0x40
007371948  ret
00737194C  bl       #0x382bfb8 ;
007371950  bl       #0x382bfc0 ;

; HotFix.BattleResultViewMainModule$$OnClickDmgStats
; RVA 0x737217C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00737217C  stp      x30, x21, [sp, #-0x20]!
007372180  stp      x20, x19, [sp, #0x10]
007372184  adrp     x20, #0x95a7000
007372188  adrp     x21, #0x8f92000
00737218C  ldrb     w8, [x20, #0xa37]
007372190  ldr      x21, [x21, #0xe38]
007372194  mov      x19, x0
007372198  tbnz     w8, #0, #0x73721bc
00737219C  adrp     x0, #0x8f92000
0073721A0  ldr      x0, [x0, #0xe38]
0073721A4  bl       #0x382bd14 ;
0073721A8  adrp     x0, #0x8ee1000
0073721AC  ldr      x0, [x0, #0x5e0]
0073721B0  bl       #0x382bd14 ;
0073721B4  mov      w8, #1
0073721B8  strb     w8, [x20, #0xa37]
0073721BC  ldr      x1, [x21]
0073721C0  ldrb     w8, [x1, #0x53]
0073721C4  tbnz     w8, #5, #0x7372240
0073721C8  adrp     x19, #0x8ee1000
0073721CC  ldr      x19, [x19, #0x5e0]
0073721D0  ldr      x0, [x19]
0073721D4  ldr      w8, [x0, #0xe0]
0073721D8  cbnz     w8, #0x73721e0
0073721DC  bl       #0x382be8c ;
0073721E0  adrp     x20, #0x9591000
0073721E4  ldrb     w8, [x20, #0x59d]
0073721E8  cbnz     w8, #0x7372200
0073721EC  adrp     x0, #0x8ee1000
0073721F0  ldr      x0, [x0, #0x5e0]
0073721F4  bl       #0x382bd14 ;
0073721F8  mov      w8, #1
0073721FC  strb     w8, [x20, #0x59d]
007372200  ldr      x0, [x19]
007372204  ldr      w8, [x0, #0xe0]
007372208  cbnz     w8, #0x7372214
00737220C  bl       #0x382be8c ;
007372210  ldr      x0, [x19]
007372214  ldr      x8, [x0, #0xb8]
007372218  ldp      x20, x19, [sp, #0x10]
00737221C  mov      w1, #0x290
007372220  mov      w3, #2
007372224  ldr      x0, [x8, #0x28]
007372228  mov      x2, xzr
00737222C  mov      x4, xzr
007372230  mov      x5, xzr
007372234  mov      x6, xzr
007372238  ldp      x30, x21, [sp], #0x20
00737223C  b        #0x7257458 ; HotFix.FrameworkExpand$$OpenView
007372240  ldr      x2, [x1, #0x60]
007372244  mov      x0, x19
007372248  ldp      x20, x19, [sp, #0x10]
00737224C  ldp      x30, x21, [sp], #0x20
007372250  br       x2

; HotFix.BattleResultViewMainModule$$StartExpAnim
; RVA 0x7372254; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007372254  stp      x30, x21, [sp, #-0x20]!
007372258  stp      x20, x19, [sp, #0x10]
00737225C  adrp     x20, #0x95a7000
007372260  adrp     x21, #0x8f92000
007372264  ldrb     w8, [x20, #0xa38]
007372268  ldr      x21, [x21, #0xed0]
00737226C  mov      x19, x0
007372270  tbnz     w8, #0, #0x7372288
007372274  adrp     x0, #0x8f92000
007372278  ldr      x0, [x0, #0xed0]
00737227C  bl       #0x382bd14 ;
007372280  mov      w8, #1
007372284  strb     w8, [x20, #0xa38]
007372288  ldr      x1, [x21]
00737228C  ldrb     w8, [x1, #0x53]
007372290  tbnz     w8, #5, #0x73722a0
007372294  ldp      x20, x19, [sp, #0x10]
007372298  ldp      x30, x21, [sp], #0x20
00737229C  ret
0073722A0  ldr      x2, [x1, #0x60]
0073722A4  mov      x0, x19
0073722A8  ldp      x20, x19, [sp, #0x10]
0073722AC  ldp      x30, x21, [sp], #0x20
0073722B0  br       x2

; HotFix.BattleResultViewMainModule$$ContinueAnim
; RVA 0x73722B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0073722B4  stp      x30, x21, [sp, #-0x20]!
0073722B8  stp      x20, x19, [sp, #0x10]
0073722BC  adrp     x20, #0x95a7000
0073722C0  adrp     x21, #0x8f92000
0073722C4  ldrb     w8, [x20, #0xa39]
0073722C8  ldr      x21, [x21, #0xed8]
0073722CC  mov      x19, x0
0073722D0  tbnz     w8, #0, #0x73722e8
0073722D4  adrp     x0, #0x8f92000
0073722D8  ldr      x0, [x0, #0xed8]
0073722DC  bl       #0x382bd14 ;
0073722E0  mov      w8, #1
0073722E4  strb     w8, [x20, #0xa39]
0073722E8  ldr      x1, [x21]
0073722EC  ldrb     w8, [x1, #0x53]
0073722F0  tbnz     w8, #5, #0x7372300
0073722F4  ldp      x20, x19, [sp, #0x10]
0073722F8  ldp      x30, x21, [sp], #0x20
0073722FC  ret
007372300  ldr      x2, [x1, #0x60]
007372304  mov      x0, x19
007372308  ldp      x20, x19, [sp, #0x10]
00737230C  ldp      x30, x21, [sp], #0x20
007372310  br       x2

; HotFix.BattleResultViewMainModule$$GetExpAdd
; RVA 0x7372314; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007372314  stp      x30, x27, [sp, #-0x50]!
007372318  stp      x26, x25, [sp, #0x10]
00737231C  stp      x24, x23, [sp, #0x20]
007372320  stp      x22, x21, [sp, #0x30]
007372324  stp      x20, x19, [sp, #0x40]
007372328  adrp     x21, #0x95a7000
00737232C  adrp     x22, #0x8f92000
007372330  ldrb     w8, [x21, #0xa3a]
007372334  ldr      x22, [x22, #0xee0]
007372338  mov      x19, x1
00737233C  mov      x20, x0
007372340  tbnz     w8, #0, #0x7372364
007372344  adrp     x0, #0x8f92000
007372348  ldr      x0, [x0, #0xee0]
00737234C  bl       #0x382bd14 ;
007372350  adrp     x0, #0x8ee6000
007372354  ldr      x0, [x0, #0x680]
007372358  bl       #0x382bd14 ;
00737235C  mov      w8, #1
007372360  strb     w8, [x21, #0xa3a]
007372364  ldr      x2, [x22]
007372368  ldrb     w8, [x2, #0x53]
00737236C  tbnz     w8, #5, #0x737242c
007372370  cbz      x19, #0x7372460
007372374  ldp      w23, w8, [x19, #0x1c]
007372378  ldr      w20, [x19, #0x18]
00737237C  cmp      w8, w20
007372380  b.le     #0x7372450
007372384  adrp     x25, #0x8ee6000
007372388  adrp     x21, #0x8f37000
00737238C  ldr      x25, [x25, #0x680]
007372390  ldr      x21, [x21, #0xea0]
007372394  mov      w24, wzr
007372398  adrp     x26, #0x95a7000
00737239C  mov      w27, #1
0073723A0  ldr      x0, [x25]
0073723A4  ldr      w8, [x0, #0xe0]
0073723A8  cbnz     w8, #0x73723b0
0073723AC  bl       #0x382be8c ;
0073723B0  mov      x0, xzr
0073723B4  bl       #0x7091c90 ; HotFix.Game$$get_Table
0073723B8  cbz      x0, #0x737245c
0073723BC  mov      w1, w20
0073723C0  mov      x2, xzr
0073723C4  bl       #0x64cfd04 ; LocalModels.LocalModelManager$$GetExp_expGlobal
0073723C8  mov      x22, x0
0073723CC  cbz      x0, #0x7372500
0073723D0  ldrb     w8, [x26, #0xa64]
0073723D4  cbnz     w8, #0x73723e4
0073723D8  mov      x0, x21
0073723DC  bl       #0x382bd14 ;
0073723E0  strb     w27, [x26, #0xa64]
0073723E4  ldr      x1, [x21]
0073723E8  ldrb     w8, [x1, #0x53]
0073723EC  tbnz     w8, #5, #0x73723f8
0073723F0  ldr      w0, [x22, #0x24]
0073723F4  b        #0x7372404 ;
0073723F8  ldr      x8, [x1, #0x60]
0073723FC  mov      x0, x22
007372400  blr      x8
007372404  ldr      w8, [x19, #0x20]
007372408  sub      w9, w24, w23
00737240C  add      w20, w20, #1
007372410  add      w24, w9, w0
007372414  cmp      w20, w8
007372418  mov      w23, wzr
00737241C  b.lt     #0x73723a0
007372420  ldr      w8, [x19, #0x24]
007372424  add      w0, w8, w24
007372428  b        #0x7372504 ;
00737242C  ldr      x3, [x2, #0x60]
007372430  mov      x0, x20
007372434  mov      x1, x19
007372438  ldp      x20, x19, [sp, #0x40]
00737243C  ldp      x22, x21, [sp, #0x30]
007372440  ldp      x24, x23, [sp, #0x20]
007372444  ldp      x26, x25, [sp, #0x10]
007372448  ldp      x30, x27, [sp], #0x50
00737244C  br       x3
007372450  ldr      w8, [x19, #0x24]
007372454  sub      w0, w8, w23
007372458  b        #0x7372504 ;
00737245C  bl       #0x382bfb8 ;
007372460  bl       #0x382bfb8 ;
007372464  b        #0x7372478 ;
007372468  b        #0x7372478 ;
00737246C  b        #0x7372478 ;
007372470  b        #0x7372478 ;
007372474  b        #0x7372478 ;
007372478  mov      x19, x0
00737247C  cmp      w1, #1
007372480  b.ne     #0x7372544
007372484  mov      x0, x19
007372488  bl       #0x89eda50 ;
00737248C  mov      x19, x0
007372490  adrp     x0, #0x8ebf000
007372494  ldr      x0, [x0, #0xc70]
007372498  bl       #0x382bd28 ;
00737249C  ldr      x8, [x19]
0073724A0  ldr      x1, [x8]
0073724A4  bl       #0x382c3e4 ;
0073724A8  tbz      w0, #0, #0x737251c
0073724AC  ldr      x19, [x19]
0073724B0  bl       #0x89eda60 ;
0073724B4  adrp     x0, #0x8ee1000
0073724B8  ldr      x0, [x0, #0x6e8]
0073724BC  bl       #0x382bd28 ;
0073724C0  ldr      w8, [x0, #0xe0]
0073724C4  cbnz     w8, #0x73724cc
0073724C8  bl       #0x382be8c ;
0073724CC  adrp     x0, #0x8f92000
0073724D0  ldr      x0, [x0, #0xee8]
0073724D4  bl       #0x382bd28 ;
0073724D8  mov      x20, x0
0073724DC  adrp     x0, #0x8f92000
0073724E0  ldr      x0, [x0, #0xef0]
0073724E4  bl       #0x382bd28 ;
0073724E8  mov      x2, x0
0073724EC  mov      w3, #0x192
0073724F0  mov      x0, x19
0073724F4  mov      x1, x20
0073724F8  mov      x4, xzr
0073724FC  bl       #0x799724c ; Logger$$LogException
007372500  mov      w0, wzr
007372504  ldp      x20, x19, [sp, #0x40]
007372508  ldp      x22, x21, [sp, #0x30]
00737250C  ldp      x24, x23, [sp, #0x20]
007372510  ldp      x26, x25, [sp, #0x10]
007372514  ldp      x30, x27, [sp], #0x50
007372518  ret
00737251C  mov      w0, #8
007372520  bl       #0x89eda70 ;
007372524  ldr      x8, [x19]
007372528  str      x8, [x0]
00737252C  adrp     x1, #0x89f3000
007372530  add      x1, x1, #0xf98
007372534  mov      x2, xzr
007372538  bl       #0x89eda80 ;
00737253C  mov      x19, x0
007372540  bl       #0x89eda60 ;
007372544  mov      x0, x19
007372548  bl       #0x3b56bfc ;
00737254C  bl       #0x3442448 ;

; HotFix.BattleResultViewMainModule$$OnShowItem
; RVA 0x7372550; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007372550  str      x30, [sp, #-0x30]!
007372554  stp      x22, x21, [sp, #0x10]
007372558  stp      x20, x19, [sp, #0x20]
00737255C  adrp     x21, #0x95a7000
007372560  adrp     x22, #0x8f92000
007372564  ldrb     w8, [x21, #0xa3b]
007372568  ldr      x22, [x22, #0xef8]
00737256C  mov      x19, x1
007372570  mov      x20, x0
007372574  tbnz     w8, #0, #0x737258c
007372578  adrp     x0, #0x8f92000
00737257C  ldr      x0, [x0, #0xef8]
007372580  bl       #0x382bd14 ;
007372584  mov      w8, #1
007372588  strb     w8, [x21, #0xa3b]
00737258C  ldr      x2, [x22]
007372590  ldrb     w8, [x2, #0x53]
007372594  tbnz     w8, #5, #0x73725d8
007372598  ldr      w8, [x20, #0x154]
00737259C  subs     w8, w8, #1
0073725A0  b.lt     #0x73725f4
0073725A4  str      w8, [x20, #0x154]
0073725A8  cbz      x19, #0x7372604
0073725AC  mov      x0, x19
0073725B0  mov      x1, xzr
0073725B4  bl       #0x74a8430 ; HotFix.UIItem$$get_Data
0073725B8  mov      x1, x0
0073725BC  mov      x0, x19
0073725C0  ldp      x20, x19, [sp, #0x20]
0073725C4  ldp      x22, x21, [sp, #0x10]
0073725C8  mov      w2, #0x10000
0073725CC  mov      x3, xzr
0073725D0  ldr      x30, [sp], #0x30
0073725D4  b        #0x74a64a8 ; HotFix.UIItem$$SetData
0073725D8  ldr      x3, [x2, #0x60]
0073725DC  mov      x0, x20
0073725E0  mov      x1, x19
0073725E4  ldp      x20, x19, [sp, #0x20]
0073725E8  ldp      x22, x21, [sp, #0x10]
0073725EC  ldr      x30, [sp], #0x30
0073725F0  br       x3
0073725F4  ldp      x20, x19, [sp, #0x20]
0073725F8  ldp      x22, x21, [sp, #0x10]
0073725FC  ldr      x30, [sp], #0x30
007372600  ret
007372604  bl       #0x382bfb8 ;

; HotFix.BattleResultViewMainModule$$ShowRecommendSkills
; RVA 0x7371954; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007371954  sub      sp, sp, #0x70
007371958  stp      x29, x30, [sp, #0x10]
00737195C  stp      x28, x27, [sp, #0x20]
007371960  stp      x26, x25, [sp, #0x30]
007371964  stp      x24, x23, [sp, #0x40]
007371968  stp      x22, x21, [sp, #0x50]
00737196C  stp      x20, x19, [sp, #0x60]
007371970  adrp     x20, #0x95a7000
007371974  adrp     x22, #0x8f92000
007371978  ldrb     w8, [x20, #0xa3c]
00737197C  ldr      x22, [x22, #0xeb8]
007371980  mov      x21, x1
007371984  mov      x19, x0
007371988  tbnz     w8, #0, #0x7371a18
00737198C  adrp     x0, #0x8ec3000
007371990  ldr      x0, [x0, #0xdc0]
007371994  bl       #0x382bd14 ;
007371998  adrp     x0, #0x8f92000
00737199C  ldr      x0, [x0, #0xeb8]
0073719A0  bl       #0x382bd14 ;
0073719A4  adrp     x0, #0x8efd000
0073719A8  ldr      x0, [x0, #0x3b0]
0073719AC  bl       #0x382bd14 ;
0073719B0  adrp     x0, #0x8ec1000
0073719B4  ldr      x0, [x0, #0x470]
0073719B8  bl       #0x382bd14 ;
0073719BC  adrp     x0, #0x8ec0000
0073719C0  ldr      x0, [x0, #0x5d0]
0073719C4  bl       #0x382bd14 ;
0073719C8  adrp     x0, #0x8ee6000
0073719CC  ldr      x0, [x0, #0x88]
0073719D0  bl       #0x382bd14 ;
0073719D4  adrp     x0, #0x8ee6000
0073719D8  ldr      x0, [x0, #0x680]
0073719DC  bl       #0x382bd14 ;
0073719E0  adrp     x0, #0x8edf000
0073719E4  ldr      x0, [x0, #0x5c8]
0073719E8  bl       #0x382bd14 ;
0073719EC  adrp     x0, #0x8ebf000
0073719F0  ldr      x0, [x0, #0x460]
0073719F4  bl       #0x382bd14 ;
0073719F8  adrp     x0, #0x8f92000
0073719FC  ldr      x0, [x0, #0xec0]
007371A00  bl       #0x382bd14 ;
007371A04  adrp     x0, #0x8f92000
007371A08  ldr      x0, [x0, #0xec8]
007371A0C  bl       #0x382bd14 ;
007371A10  mov      w8, #1
007371A14  strb     w8, [x20, #0xa3c]
007371A18  ldr      x2, [x22]
007371A1C  ldrb     w8, [x2, #0x53]
007371A20  tbnz     w8, #5, #0x7371abc
007371A24  mov      x0, x19
007371A28  bl       #0x7372608 ; HotFix.BattleResultViewMainModule$$ClearRecommendSkillItems
007371A2C  ldr      x0, [x19, #0x128]
007371A30  cbz      x0, #0x7372174
007371A34  mov      x1, xzr
007371A38  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007371A3C  adrp     x24, #0x8ee6000
007371A40  ldr      x24, [x24, #0x88]
007371A44  mov      x20, x0
007371A48  ldr      x8, [x24]
007371A4C  ldr      w9, [x8, #0xe0]
007371A50  cbnz     w9, #0x7371a5c
007371A54  mov      x0, x8
007371A58  bl       #0x382be8c ;
007371A5C  mov      x0, x20
007371A60  mov      w1, wzr
007371A64  mov      x2, xzr
007371A68  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007371A6C  ldr      x8, [x19, #0x158]
007371A70  cbz      x8, #0x7372174
007371A74  ldrb     w8, [x8, #0x10]
007371A78  cbz      w8, #0x7371ae8
007371A7C  ldr      x0, [x24]
007371A80  ldr      x19, [x19, #0x120]
007371A84  ldr      w8, [x0, #0xe0]
007371A88  cbnz     w8, #0x7371a90
007371A8C  bl       #0x382be8c ;
007371A90  mov      x0, x19
007371A94  ldp      x20, x19, [sp, #0x60]
007371A98  ldp      x22, x21, [sp, #0x50]
007371A9C  ldp      x24, x23, [sp, #0x40]
007371AA0  ldp      x26, x25, [sp, #0x30]
007371AA4  ldp      x28, x27, [sp, #0x20]
007371AA8  ldp      x29, x30, [sp, #0x10]
007371AAC  mov      w1, wzr
007371AB0  mov      x2, xzr
007371AB4  add      sp, sp, #0x70
007371AB8  b        #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007371ABC  ldr      x3, [x2, #0x60]
007371AC0  mov      x0, x19
007371AC4  mov      x1, x21
007371AC8  ldp      x20, x19, [sp, #0x60]
007371ACC  ldp      x22, x21, [sp, #0x50]
007371AD0  ldp      x24, x23, [sp, #0x40]
007371AD4  ldp      x26, x25, [sp, #0x30]
007371AD8  ldp      x28, x27, [sp, #0x20]
007371ADC  ldp      x29, x30, [sp, #0x10]
007371AE0  add      sp, sp, #0x70
007371AE4  br       x3
007371AE8  cbz      x21, #0x7371a7c
007371AEC  adrp     x8, #0x8efd000
007371AF0  ldr      x8, [x8, #0x3b0]
007371AF4  ldr      x9, [x21]
007371AF8  ldr      x8, [x8]
007371AFC  ldrb     w11, [x9, #0x130]
007371B00  ldrb     w10, [x8, #0x130]
007371B04  cmp      w11, w10
007371B08  b.lo     #0x7371a7c
007371B0C  ldr      x9, [x9, #0xc8]
007371B10  add      x9, x9, x10, lsl #3
007371B14  ldur     x9, [x9, #-8]
007371B18  cmp      x9, x8
007371B1C  b.ne     #0x7371a7c
007371B20  mov      x0, x21
007371B24  mov      x1, xzr
007371B28  bl       #0x68afb38 ; LocalModels.Bean.Chapter_MainChapter$$GetSuggestedSkills
007371B2C  ldr      x8, [x19, #0x120]
007371B30  cbz      x8, #0x7372174
007371B34  mov      x22, x0
007371B38  mov      x0, x8
007371B3C  mov      x1, xzr
007371B40  bl       #0x874e0b8 ; UnityEngine.GameObject$$get_transform
007371B44  str      x0, [sp, #8]
007371B48  cbz      x22, #0x7371d08
007371B4C  ldr      x8, [x22, #0x18]
007371B50  cmp      w8, #1
007371B54  b.lt     #0x7371d04
007371B58  adrp     x23, #0x8f3e000
007371B5C  ldr      x23, [x23, #0x2d0]
007371B60  mov      x20, xzr
007371B64  mov      w28, wzr
007371B68  and      x8, x8, #0xffffffff
007371B6C  add      x29, x22, #0x20
007371B70  cmp      x20, w8, uxtw
007371B74  b.hs     #0x7372178
007371B78  adrp     x8, #0x8ee6000
007371B7C  ldr      x8, [x8, #0x680]
007371B80  ldr      w25, [x29, x20, lsl #2]
007371B84  ldr      x0, [x8]
007371B88  ldr      w8, [x0, #0xe0]
007371B8C  cbnz     w8, #0x7371b94
007371B90  bl       #0x382be8c ;
007371B94  mov      x0, xzr
007371B98  bl       #0x7091c90 ; HotFix.Game$$get_Table
007371B9C  cbz      x0, #0x7372174
007371BA0  mov      w1, w25
007371BA4  mov      x2, xzr
007371BA8  bl       #0x64dec44 ; LocalModels.LocalModelManager$$GetSkillLab_SkilInfo
007371BAC  cbz      x0, #0x7371cec
007371BB0  adrp     x8, #0x95a7000
007371BB4  ldrb     w8, [x8, #0xa65]
007371BB8  mov      x26, x0
007371BBC  cbnz     w8, #0x7371bd4
007371BC0  mov      x0, x23
007371BC4  bl       #0x382bd14 ;
007371BC8  adrp     x8, #0x95a7000
007371BCC  mov      w9, #1
007371BD0  strb     w9, [x8, #0xa65]
007371BD4  ldr      x1, [x23]
007371BD8  ldrb     w8, [x1, #0x53]
007371BDC  tbnz     w8, #5, #0x7371be8
007371BE0  ldr      x0, [x26, #0x40]
007371BE4  b        #0x7371bf4 ;
007371BE8  ldr      x8, [x1, #0x60]
007371BEC  mov      x0, x26
007371BF0  blr      x8
007371BF4  mov      x1, xzr
007371BF8  bl       #0x79e2368 ; System.String$$IsNullOrEmpty
007371BFC  tbnz     w0, #0, #0x7371cec
007371C00  ldr      x1, [sp, #8]
007371C04  mov      x0, x19
007371C08  bl       #0x73728ec ; HotFix.BattleResultViewMainModule$$CreateRecommendItem
007371C0C  adrp     x8, #0x8ebf000
007371C10  ldr      x8, [x8, #0x460]
007371C14  mov      x27, x0
007371C18  ldr      x8, [x8]
007371C1C  ldr      w9, [x8, #0xe0]
007371C20  cbnz     w9, #0x7371c2c
007371C24  mov      x0, x8
007371C28  bl       #0x382be8c ;
007371C2C  mov      x0, x27
007371C30  mov      x1, xzr
007371C34  mov      x2, xzr
007371C38  bl       #0x874f4f0 ; UnityEngine.Object$$op_Equality
007371C3C  tbnz     w0, #0, #0x7371cec
007371C40  adrp     x8, #0x95a7000
007371C44  ldrb     w8, [x8, #0xa66]
007371C48  cbnz     w8, #0x7371c64
007371C4C  adrp     x0, #0x8f3e000
007371C50  ldr      x0, [x0, #0x2c0]
007371C54  bl       #0x382bd14 ;
007371C58  mov      w8, #1
007371C5C  adrp     x9, #0x95a7000
007371C60  strb     w8, [x9, #0xa66]
007371C64  adrp     x8, #0x8f3e000
007371C68  ldr      x8, [x8, #0x2c0]
007371C6C  ldr      x1, [x8]
007371C70  ldrb     w8, [x1, #0x53]
007371C74  tbnz     w8, #5, #0x7371c80
007371C78  ldr      w28, [x26, #0x38]
007371C7C  b        #0x7371c90 ;
007371C80  ldr      x8, [x1, #0x60]
007371C84  mov      x0, x26
007371C88  blr      x8
007371C8C  mov      w28, w0
007371C90  adrp     x8, #0x95a7000
007371C94  ldrb     w8, [x8, #0xa65]
007371C98  cbnz     w8, #0x7371cb0
007371C9C  mov      x0, x23
007371CA0  bl       #0x382bd14 ;
007371CA4  adrp     x8, #0x95a7000
007371CA8  mov      w9, #1
007371CAC  strb     w9, [x8, #0xa65]
007371CB0  ldr      x1, [x23]
007371CB4  ldrb     w8, [x1, #0x53]
007371CB8  tbnz     w8, #5, #0x7371cc4
007371CBC  ldr      x3, [x26, #0x40]
007371CC0  b        #0x7371cd4 ;
007371CC4  ldr      x8, [x1, #0x60]
007371CC8  mov      x0, x26
007371CCC  blr      x8
007371CD0  mov      x3, x0
007371CD4  cbz      x27, #0x7372174
007371CD8  mov      x0, x27
007371CDC  mov      w1, w25
007371CE0  mov      w2, w28
007371CE4  bl       #0x736d618 ; HotFix.BattleResultRecommendItem$$SetSkill
007371CE8  mov      w28, #1
007371CEC  ldr      w8, [x22, #0x18]
007371CF0  add      x20, x20, #1
007371CF4  cmp      x20, w8, sxtw
007371CF8  b.lt     #0x7371b70
007371CFC  and      w22, w28, #1
007371D00  b        #0x7371d08 ;
007371D04  mov      w22, wzr
007371D08  adrp     x20, #0x95a7000
007371D0C  ldrb     w8, [x20, #0xa67]
007371D10  cbnz     w8, #0x7371d28
007371D14  adrp     x0, #0x8f26000
007371D18  ldr      x0, [x0, #0xc88]
007371D1C  bl       #0x382bd14 ;
007371D20  mov      w8, #1
007371D24  strb     w8, [x20, #0xa67]
007371D28  adrp     x8, #0x8f26000
007371D2C  ldr      x8, [x8, #0xc88]
007371D30  ldr      x1, [x8]
007371D34  ldrb     w8, [x1, #0x53]
007371D38  tbnz     w8, #5, #0x7371d44
007371D3C  ldr      x21, [x21, #0xe0]
007371D40  b        #0x7371d54 ;
007371D44  ldr      x8, [x1, #0x60]
007371D48  mov      x0, x21
007371D4C  blr      x8
007371D50  mov      x21, x0
007371D54  cbz      x21, #0x7371fc4
007371D58  ldr      x8, [x21, #0x18]
007371D5C  cmp      w8, #1
007371D60  b.lt     #0x7371fc4
007371D64  stp      w22, wzr, [sp]
007371D68  adrp     x29, #0x8ee6000
007371D6C  adrp     x28, #0x8f37000
007371D70  ldr      x29, [x29, #0x680]
007371D74  ldr      x28, [x28, #0xfb0]
007371D78  mov      x25, xzr
007371D7C  and      x8, x8, #0xffffffff
007371D80  add      x20, x21, #0x20
007371D84  adrp     x22, #0x95a7000
007371D88  cmp      x25, w8, uxtw
007371D8C  b.hs     #0x7372178
007371D90  ldr      x0, [x29]
007371D94  ldr      w23, [x20, x25, lsl #2]
007371D98  ldr      w8, [x0, #0xe0]
007371D9C  cbnz     w8, #0x7371da4
007371DA0  bl       #0x382be8c ;
007371DA4  mov      x0, xzr
007371DA8  bl       #0x7091c90 ; HotFix.Game$$get_Table
007371DAC  cbz      x0, #0x7372174
007371DB0  mov      w1, w23
007371DB4  mov      x2, xzr
007371DB8  bl       #0x64d97fc ; LocalModels.LocalModelManager$$GetFunction_Function
007371DBC  cbz      x0, #0x7371fa8
007371DC0  ldrb     w8, [x22, #0xa68]
007371DC4  mov      x26, x0
007371DC8  cbnz     w8, #0x7371ddc
007371DCC  mov      x0, x28
007371DD0  bl       #0x382bd14 ;
007371DD4  mov      w8, #1
007371DD8  strb     w8, [x22, #0xa68]
007371DDC  ldr      x1, [x28]
007371DE0  ldrb     w8, [x1, #0x53]
007371DE4  tbnz     w8, #5, #0x7371df0
007371DE8  ldr      x0, [x26, #0x58]
007371DEC  b        #0x7371dfc ;
007371DF0  ldr      x8, [x1, #0x60]
007371DF4  mov      x0, x26
007371DF8  blr      x8
007371DFC  mov      x1, xzr
007371E00  bl       #0x79e2368 ; System.String$$IsNullOrEmpty
007371E04  tbnz     w0, #0, #0x7371fa8
007371E08  ldr      x1, [sp, #8]
007371E0C  mov      x0, x19
007371E10  bl       #0x73728ec ; HotFix.BattleResultViewMainModule$$CreateRecommendItem
007371E14  adrp     x8, #0x8ebf000
007371E18  ldr      x8, [x8, #0x460]
007371E1C  mov      x27, x0
007371E20  ldr      x8, [x8]
007371E24  ldr      w9, [x8, #0xe0]
007371E28  cbnz     w9, #0x7371e34
007371E2C  mov      x0, x8
007371E30  bl       #0x382be8c ;
007371E34  mov      x0, x27
007371E38  mov      x1, xzr
007371E3C  mov      x2, xzr
007371E40  bl       #0x874f4f0 ; UnityEngine.Object$$op_Equality
007371E44  tbnz     w0, #0, #0x7371fa8
007371E48  adrp     x8, #0x95a7000
007371E4C  ldrb     w8, [x8, #0xa69]
007371E50  cbnz     w8, #0x7371e6c
007371E54  adrp     x0, #0x8f37000
007371E58  ldr      x0, [x0, #0xfa0]
007371E5C  bl       #0x382bd14 ;
007371E60  mov      w8, #1
007371E64  adrp     x9, #0x95a7000
007371E68  strb     w8, [x9, #0xa69]
007371E6C  adrp     x8, #0x8f37000
007371E70  ldr      x8, [x8, #0xfa0]
007371E74  ldr      x1, [x8]
007371E78  ldrb     w8, [x1, #0x53]
007371E7C  tbnz     w8, #5, #0x7371e8c
007371E80  ldr      w8, [x26, #0x50]
007371E84  str      w8, [sp, #4]
007371E88  b        #0x7371e9c ;
007371E8C  ldr      x8, [x1, #0x60]
007371E90  mov      x0, x26
007371E94  blr      x8
007371E98  str      w0, [sp, #4]
007371E9C  ldrb     w8, [x22, #0xa68]
007371EA0  cbnz     w8, #0x7371eb4
007371EA4  mov      x0, x28
007371EA8  bl       #0x382bd14 ;
007371EAC  mov      w8, #1
007371EB0  strb     w8, [x22, #0xa68]
007371EB4  ldr      x1, [x28]
007371EB8  mov      x8, x28
007371EBC  mov      x22, x29
007371EC0  ldrb     w8, [x1, #0x53]
007371EC4  tbnz     w8, #5, #0x7371ed0
007371EC8  ldr      x29, [x26, #0x58]
007371ECC  b        #0x7371ee0 ;
007371ED0  ldr      x8, [x1, #0x60]
007371ED4  mov      x0, x26
007371ED8  blr      x8
007371EDC  mov      x29, x0
007371EE0  adrp     x8, #0x95a6000
007371EE4  ldrb     w8, [x8, #0xed9]
007371EE8  cbnz     w8, #0x7371f04
007371EEC  adrp     x0, #0x8f37000
007371EF0  ldr      x0, [x0, #0xf60]
007371EF4  bl       #0x382bd14 ;
007371EF8  mov      w8, #1
007371EFC  adrp     x9, #0x95a6000
007371F00  strb     w8, [x9, #0xed9]
007371F04  adrp     x8, #0x8f37000
007371F08  ldr      x8, [x8, #0xf60]
007371F0C  ldr      x1, [x8]
007371F10  ldrb     w8, [x1, #0x53]
007371F14  tbnz     w8, #5, #0x7371f20
007371F18  ldr      x23, [x26, #0x38]
007371F1C  b        #0x7371f30 ;
007371F20  ldr      x8, [x1, #0x60]
007371F24  mov      x0, x26
007371F28  blr      x8
007371F2C  mov      x23, x0
007371F30  adrp     x8, #0x95a7000
007371F34  ldrb     w8, [x8, #0xa6a]
007371F38  cbnz     w8, #0x7371f54
007371F3C  adrp     x0, #0x8f37000
007371F40  ldr      x0, [x0, #0xfd0]
007371F44  bl       #0x382bd14 ;
007371F48  mov      w8, #1
007371F4C  adrp     x9, #0x95a7000
007371F50  strb     w8, [x9, #0xa6a]
007371F54  adrp     x8, #0x8f37000
007371F58  ldr      x8, [x8, #0xfd0]
007371F5C  ldr      x1, [x8]
007371F60  ldrb     w8, [x1, #0x53]
007371F64  tbnz     w8, #5, #0x7371f70
007371F68  ldr      w4, [x26, #0x68]
007371F6C  b        #0x7371f80 ;
007371F70  ldr      x8, [x1, #0x60]
007371F74  mov      x0, x26
007371F78  blr      x8
007371F7C  mov      w4, w0
007371F80  cbz      x27, #0x7372174
007371F84  ldr      w1, [sp, #4]
007371F88  mov      x0, x27
007371F8C  mov      x2, x29
007371F90  mov      x3, x23
007371F94  bl       #0x736d7c0 ; HotFix.BattleResultRecommendItem$$SetFunction
007371F98  mov      w8, #1
007371F9C  mov      x29, x22
007371FA0  adrp     x22, #0x95a7000
007371FA4  str      w8, [sp, #4]
007371FA8  ldr      w8, [x21, #0x18]
007371FAC  add      x25, x25, #1
007371FB0  cmp      x25, w8, sxtw
007371FB4  b.lt     #0x7371d88
007371FB8  ldp      w22, w8, [sp]
007371FBC  and      w23, w8, #1
007371FC0  b        #0x7371fc8 ;
007371FC4  mov      w23, wzr
007371FC8  ldr      x0, [x24]
007371FCC  ldr      x21, [x19, #0x120]
007371FD0  orr      w20, w22, w23
007371FD4  ldr      w8, [x0, #0xe0]
007371FD8  cbnz     w8, #0x7371fe0
007371FDC  bl       #0x382be8c ;
007371FE0  mov      x0, x21
007371FE4  mov      w1, w20
007371FE8  mov      x2, xzr
007371FEC  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007371FF0  cbz      w20, #0x7372154
007371FF4  adrp     x8, #0x8f92000
007371FF8  adrp     x9, #0x8ec3000
007371FFC  ldr      x20, [x19, #0x130]
007372000  ldr      x8, [x8, #0xec8]
007372004  b        #0x89ed5bc ;
007372008  cmp      w23, #0
00737200C  ldr      x22, [x9]
007372010  adrp     x9, #0x8f92000
007372014  ldr      x9, [x9, #0xec0]
007372018  csel     x9, x8, x9, ne
00737201C  ldr      x8, [x22, #0x38]
007372020  ldr      x21, [x9]
007372024  cbnz     x8, #0x7372034
007372028  mov      x0, x22
00737202C  bl       #0x3a7e668 ;
007372030  ldr      x8, [x22, #0x38]
007372034  ldr      x0, [x8, #0x10]
007372038  ldrb     w8, [x0, #0x135]
00737203C  tbnz     w8, #0, #0x7372044
007372040  bl       #0x3a7e60c ;
007372044  ldr      w8, [x0, #0xe0]
007372048  cbnz     w8, #0x7372050
00737204C  bl       #0x382be8c ;
007372050  ldr      x8, [x22, #0x38]
007372054  ldr      x0, [x8, #0x10]
007372058  ldrb     w8, [x0, #0x135]
00737205C  tbnz     w8, #0, #0x7372064
007372060  bl       #0x3a7e60c ;
007372064  cbz      x20, #0x7372174
007372068  ldr      x8, [x0, #0xb8]
00737206C  mov      x0, x20
007372070  mov      x1, x21
007372074  mov      x3, xzr
007372078  ldr      x2, [x8]
00737207C  bl       #0x41894f4 ; Framework.Logic.UI.CustomText$$SetText
007372080  ldr      x0, [x19, #0x118]
007372084  cbz      x0, #0x7372174
007372088  adrp     x8, #0x8ec0000
00737208C  ldr      x8, [x8, #0x5d0]
007372090  ldr      x1, [x8]
007372094  bl       #0x4556224 ; UnityEngine.Component$$GetComponent<object>
007372098  adrp     x8, #0x8edf000
00737209C  ldr      x8, [x8, #0x5c8]
0073720A0  mov      x20, x0
0073720A4  ldr      x8, [x8]
0073720A8  ldr      w9, [x8, #0xe0]
0073720AC  cbnz     w9, #0x73720b8
0073720B0  mov      x0, x8
0073720B4  bl       #0x382be8c ;
0073720B8  mov      x0, x20
0073720BC  mov      x1, xzr
0073720C0  bl       #0x8990b8c ; UnityEngine.UI.LayoutRebuilder$$ForceRebuildLayoutImmediate
0073720C4  ldr      x0, [x19, #0x118]
0073720C8  cbz      x0, #0x7372174
0073720CC  mov      w1, wzr
0073720D0  mov      x2, xzr
0073720D4  bl       #0x8749d30 ; UnityEngine.Behaviour$$set_enabled
0073720D8  ldr      x0, [x19, #0x118]
0073720DC  cbz      x0, #0x7372174
0073720E0  adrp     x8, #0x8ec1000
0073720E4  ldr      x8, [x8, #0x470]
0073720E8  ldr      x1, [x8]
0073720EC  bl       #0x4556224 ; UnityEngine.Component$$GetComponent<object>
0073720F0  adrp     x8, #0x8ebf000
0073720F4  ldr      x8, [x8, #0x460]
0073720F8  mov      x19, x0
0073720FC  ldr      x8, [x8]
007372100  ldr      w9, [x8, #0xe0]
007372104  cbnz     w9, #0x7372110
007372108  mov      x0, x8
00737210C  bl       #0x382be8c ;
007372110  mov      x0, x19
007372114  mov      x1, xzr
007372118  mov      x2, xzr
00737211C  bl       #0x874dafc ; UnityEngine.Object$$op_Inequality
007372120  tbz      w0, #0, #0x7372154
007372124  cbz      x19, #0x7372174
007372128  mov      x0, x19
00737212C  ldp      x20, x19, [sp, #0x60]
007372130  ldp      x22, x21, [sp, #0x50]
007372134  ldp      x24, x23, [sp, #0x40]
007372138  ldp      x26, x25, [sp, #0x30]
00737213C  ldp      x28, x27, [sp, #0x20]
007372140  ldp      x29, x30, [sp, #0x10]
007372144  mov      w1, wzr
007372148  mov      x2, xzr
00737214C  add      sp, sp, #0x70
007372150  b        #0x8749d30 ; UnityEngine.Behaviour$$set_enabled
007372154  ldp      x20, x19, [sp, #0x60]
007372158  ldp      x22, x21, [sp, #0x50]
00737215C  ldp      x24, x23, [sp, #0x40]
007372160  ldp      x26, x25, [sp, #0x30]
007372164  ldp      x28, x27, [sp, #0x20]
007372168  ldp      x29, x30, [sp, #0x10]
00737216C  add      sp, sp, #0x70
007372170  ret
007372174  bl       #0x382bfb8 ;
007372178  bl       #0x382bfc0 ;

; HotFix.BattleResultViewMainModule$$CreateRecommendItem
; RVA 0x73728EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0073728EC  str      x30, [sp, #-0x30]!
0073728F0  stp      x22, x21, [sp, #0x10]
0073728F4  stp      x20, x19, [sp, #0x20]
0073728F8  adrp     x21, #0x95a7000
0073728FC  adrp     x22, #0x8f92000
007372900  ldrb     w8, [x21, #0xa3d]
007372904  ldr      x22, [x22, #0xf20]
007372908  mov      x20, x1
00737290C  mov      x19, x0
007372910  tbnz     w8, #0, #0x73729b8
007372914  adrp     x0, #0x8ec1000
007372918  ldr      x0, [x0, #0x8a8]
00737291C  bl       #0x382bd14 ;
007372920  adrp     x0, #0x8f92000
007372924  ldr      x0, [x0, #0xf20]
007372928  bl       #0x382bd14 ;
00737292C  adrp     x0, #0x8f92000
007372930  ldr      x0, [x0, #0xf28]
007372934  bl       #0x382bd14 ;
007372938  adrp     x0, #0x8ee6000
00737293C  ldr      x0, [x0, #0x88]
007372940  bl       #0x382bd14 ;
007372944  adrp     x0, #0x8f92000
007372948  ldr      x0, [x0, #0xf30]
00737294C  bl       #0x382bd14 ;
007372950  adrp     x0, #0x8f92000
007372954  ldr      x0, [x0, #0xf38]
007372958  bl       #0x382bd14 ;
00737295C  adrp     x0, #0x8f92000
007372960  ldr      x0, [x0, #0xf40]
007372964  bl       #0x382bd14 ;
007372968  adrp     x0, #0x8ee1000
00737296C  ldr      x0, [x0, #0x6e8]
007372970  bl       #0x382bd14 ;
007372974  adrp     x0, #0x8ebf000
007372978  ldr      x0, [x0, #0xb50]
00737297C  bl       #0x382bd14 ;
007372980  adrp     x0, #0x8ebf000
007372984  ldr      x0, [x0, #0x460]
007372988  bl       #0x382bd14 ;
00737298C  adrp     x0, #0x8f92000
007372990  ldr      x0, [x0, #0xf48]
007372994  bl       #0x382bd14 ;
007372998  adrp     x0, #0x8f92000
00737299C  ldr      x0, [x0, #0xf50]
0073729A0  bl       #0x382bd14 ;
0073729A4  adrp     x0, #0x8f92000
0073729A8  ldr      x0, [x0, #0xef0]
0073729AC  bl       #0x382bd14 ;
0073729B0  mov      w8, #1
0073729B4  strb     w8, [x21, #0xa3d]
0073729B8  ldr      x2, [x22]
0073729BC  ldrb     w8, [x2, #0x53]
0073729C0  tbnz     w8, #5, #0x7372b1c
0073729C4  ldr      x0, [x19, #0x128]
0073729C8  cbz      x0, #0x7372bf4
0073729CC  mov      x1, xzr
0073729D0  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
0073729D4  adrp     x22, #0x8ebf000
0073729D8  ldr      x22, [x22, #0x460]
0073729DC  mov      x21, x0
0073729E0  ldr      x8, [x22]
0073729E4  ldr      w9, [x8, #0xe0]
0073729E8  cbnz     w9, #0x73729f4
0073729EC  mov      x0, x8
0073729F0  bl       #0x382be8c ;
0073729F4  adrp     x8, #0x8ebf000
0073729F8  ldr      x8, [x8, #0xb50]
0073729FC  mov      x0, x21
007372A00  mov      x1, x20
007372A04  ldr      x2, [x8]
007372A08  bl       #0x4685734 ; UnityEngine.Object$$Instantiate<object>
007372A0C  adrp     x8, #0x8ee6000
007372A10  ldr      x8, [x8, #0x88]
007372A14  mov      x20, x0
007372A18  ldr      x8, [x8]
007372A1C  ldr      w9, [x8, #0xe0]
007372A20  cbnz     w9, #0x7372a2c
007372A24  mov      x0, x8
007372A28  bl       #0x382be8c ;
007372A2C  mov      w1, #1
007372A30  mov      x0, x20
007372A34  mov      x2, xzr
007372A38  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007372A3C  cbz      x20, #0x7372bf4
007372A40  mov      x0, x20
007372A44  mov      x1, xzr
007372A48  bl       #0x874e0b8 ; UnityEngine.GameObject$$get_transform
007372A4C  cbz      x0, #0x7372bf4
007372A50  fmov     s0, #0.50000000
007372A54  fmov     s1, #0.50000000
007372A58  fmov     s2, #0.50000000
007372A5C  mov      x1, xzr
007372A60  bl       #0x875ca48 ; UnityEngine.Transform$$set_localScale
007372A64  adrp     x8, #0x8f92000
007372A68  ldr      x8, [x8, #0xf30]
007372A6C  mov      x0, x20
007372A70  ldr      x1, [x8]
007372A74  bl       #0x4630ca4 ; Framework.Logic.Modules.GameObjectExpand$$GetOrAddComponent<object>
007372A78  cbz      x0, #0x7372bf4
007372A7C  fmov     s0, wzr
007372A80  mov      x1, xzr
007372A84  bl       #0x897d2d8 ; UnityEngine.CanvasGroup$$set_alpha
007372A88  adrp     x8, #0x8f92000
007372A8C  ldr      x8, [x8, #0xf38]
007372A90  mov      x0, x20
007372A94  ldr      x1, [x8]
007372A98  bl       #0x462f580 ; UnityEngine.GameObject$$GetComponent<object>
007372A9C  mov      x1, xzr
007372AA0  mov      x2, xzr
007372AA4  mov      x21, x0
007372AA8  bl       #0x874f4f0 ; UnityEngine.Object$$op_Equality
007372AAC  tbz      w0, #0, #0x7372b38
007372AB0  adrp     x8, #0x8ee1000
007372AB4  ldr      x8, [x8, #0x6e8]
007372AB8  ldr      x0, [x8]
007372ABC  ldr      w8, [x0, #0xe0]
007372AC0  cbnz     w8, #0x7372ac8
007372AC4  bl       #0x382be8c ;
007372AC8  adrp     x8, #0x8f92000
007372ACC  adrp     x9, #0x8f92000
007372AD0  adrp     x10, #0x8f92000
007372AD4  ldr      x8, [x8, #0xf50]
007372AD8  ldr      x9, [x9, #0xf48]
007372ADC  ldr      x10, [x10, #0xef0]
007372AE0  mov      w3, #0x201
007372AE4  ldr      x0, [x8]
007372AE8  ldr      x1, [x9]
007372AEC  ldr      x2, [x10]
007372AF0  mov      x4, xzr
007372AF4  bl       #0x7997754 ; Logger$$LogError
007372AF8  ldr      x0, [x22]
007372AFC  ldr      w8, [x0, #0xe0]
007372B00  cbnz     w8, #0x7372b08
007372B04  bl       #0x382be8c ;
007372B08  mov      x0, x20
007372B0C  mov      x1, xzr
007372B10  bl       #0x87533e4 ; UnityEngine.Object$$Destroy
007372B14  mov      x21, xzr
007372B18  b        #0x7372be0 ;
007372B1C  ldr      x3, [x2, #0x60]
007372B20  mov      x0, x19
007372B24  mov      x1, x20
007372B28  ldp      x20, x19, [sp, #0x20]
007372B2C  ldp      x22, x21, [sp, #0x10]
007372B30  ldr      x30, [sp], #0x30
007372B34  br       x3
007372B38  adrp     x8, #0x8ec1000
007372B3C  ldr      x8, [x8, #0x8a8]
007372B40  ldr      x0, [x8]
007372B44  bl       #0x382bfa0 ;
007372B48  adrp     x8, #0x8f92000
007372B4C  ldr      x8, [x8, #0xf28]
007372B50  mov      x1, x19
007372B54  mov      x3, xzr
007372B58  mov      x20, x0
007372B5C  ldr      x2, [x8]
007372B60  bl       #0x5f41b1c ; System.Action<int>$$.ctor
007372B64  cbz      x21, #0x7372bf4
007372B68  mov      x0, x21
007372B6C  mov      x1, x20
007372B70  bl       #0x736d31c ; HotFix.BattleResultRecommendItem$$Init
007372B74  ldr      x0, [x19, #0x148]
007372B78  cbz      x0, #0x7372bf4
007372B7C  adrp     x9, #0x8f92000
007372B80  ldr      x9, [x9, #0xf40]
007372B84  ldr      w10, [x0, #0x1c]
007372B88  ldr      x8, [x0, #0x10]
007372B8C  ldr      x9, [x9]
007372B90  add      w10, w10, #1
007372B94  str      w10, [x0, #0x1c]
007372B98  cbz      x8, #0x7372bf4
007372B9C  ldrsw    x10, [x0, #0x18]
007372BA0  ldr      w11, [x8, #0x18]
007372BA4  cmp      w10, w11
007372BA8  b.hs     #0x7372bcc
007372BAC  add      w9, w10, #1
007372BB0  add      x8, x8, x10, lsl #3
007372BB4  str      w9, [x0, #0x18]
007372BB8  str      x21, [x8, #0x20]!
007372BBC  mov      x0, x8
007372BC0  mov      x1, x21
007372BC4  bl       #0x382bcb8 ;
007372BC8  b        #0x7372be0 ;
007372BCC  ldr      x8, [x9, #0x20]
007372BD0  mov      x1, x21
007372BD4  ldr      x8, [x8, #0xc0]
007372BD8  ldr      x2, [x8, #0x70]
007372BDC  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
007372BE0  mov      x0, x21
007372BE4  ldp      x20, x19, [sp, #0x20]
007372BE8  ldp      x22, x21, [sp, #0x10]
007372BEC  ldr      x30, [sp], #0x30
007372BF0  ret
007372BF4  bl       #0x382bfb8 ;

; HotFix.BattleResultViewMainModule$$PlayRecommendSkillAnim
; RVA 0x7372BF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007372BF8  str      d8, [sp, #-0x60]!
007372BFC  stp      x30, x27, [sp, #0x10]
007372C00  stp      x26, x25, [sp, #0x20]
007372C04  stp      x24, x23, [sp, #0x30]
007372C08  stp      x22, x21, [sp, #0x40]
007372C0C  stp      x20, x19, [sp, #0x50]
007372C10  adrp     x20, #0x95a7000
007372C14  adrp     x21, #0x8f92000
007372C18  ldrb     w8, [x20, #0xa3e]
007372C1C  ldr      x21, [x21, #0xf58]
007372C20  mov      x19, x0
007372C24  tbnz     w8, #0, #0x7372c84
007372C28  adrp     x0, #0x8f92000
007372C2C  ldr      x0, [x0, #0xf58]
007372C30  bl       #0x382bd14 ;
007372C34  adrp     x0, #0x8ec2000
007372C38  ldr      x0, [x0, #0x150]
007372C3C  bl       #0x382bd14 ;
007372C40  adrp     x0, #0x8f92000
007372C44  ldr      x0, [x0, #0xf10]
007372C48  bl       #0x382bd14 ;
007372C4C  adrp     x0, #0x8ec2000
007372C50  ldr      x0, [x0, #0x50]
007372C54  bl       #0x382bd14 ;
007372C58  adrp     x0, #0x8f7d000
007372C5C  ldr      x0, [x0, #0x778]
007372C60  bl       #0x382bd14 ;
007372C64  adrp     x0, #0x8f92000
007372C68  ldr      x0, [x0, #0xf60]
007372C6C  bl       #0x382bd14 ;
007372C70  adrp     x0, #0x8f92000
007372C74  ldr      x0, [x0, #0xf68]
007372C78  bl       #0x382bd14 ;
007372C7C  mov      w8, #1
007372C80  strb     w8, [x20, #0xa3e]
007372C84  ldr      x1, [x21]
007372C88  ldrb     w8, [x1, #0x53]
007372C8C  tbnz     w8, #5, #0x7372da4
007372C90  ldr      x8, [x19, #0x148]
007372C94  cbz      x8, #0x7372da0
007372C98  ldr      w8, [x8, #0x18]
007372C9C  cbz      w8, #0x7372df4
007372CA0  ldr      x0, [x19, #0x140]
007372CA4  cbz      x0, #0x7372cb4
007372CA8  mov      w1, wzr
007372CAC  mov      x2, xzr
007372CB0  bl       #0x40e874c ; DG.Tweening.TweenExtensions$$Kill
007372CB4  adrp     x8, #0x8ec2000
007372CB8  ldr      x8, [x8, #0x150]
007372CBC  add      x20, x19, #0x140
007372CC0  ldr      x0, [x8]
007372CC4  ldr      w8, [x0, #0xe0]
007372CC8  cbnz     w8, #0x7372cd0
007372CCC  bl       #0x382be8c ;
007372CD0  mov      x0, xzr
007372CD4  bl       #0x40e64bc ; DG.Tweening.DOTween$$Sequence
007372CD8  mov      x1, x0
007372CDC  str      x0, [x19, #0x140]
007372CE0  mov      x0, x20
007372CE4  bl       #0x382bcb8 ;
007372CE8  ldr      x8, [x19, #0x148]
007372CEC  cbz      x8, #0x7372da0
007372CF0  adrp     x9, #0x197f000
007372CF4  adrp     x25, #0x8f92000
007372CF8  adrp     x26, #0x8ec2000
007372CFC  adrp     x27, #0x8f92000
007372D00  ldr      s8, [x9, #0x10]
007372D04  ldr      x25, [x25, #0xf68]
007372D08  ldr      x26, [x26, #0x50]
007372D0C  ldr      x27, [x27, #0xf60]
007372D10  mov      w24, wzr
007372D14  ldr      w8, [x8, #0x18]
007372D18  cmp      w24, w8
007372D1C  b.ge     #0x7372dc8
007372D20  ldr      x0, [x25]
007372D24  bl       #0x382bfa0 ;
007372D28  mov      x1, xzr
007372D2C  mov      x21, x0
007372D30  bl       #0x7373f08 ; HotFix.BattleResultViewMainModule.<>c__DisplayClass44_0$$.ctor
007372D34  cbz      x21, #0x7372da0
007372D38  mov      x22, x21
007372D3C  str      x19, [x22, #0x18]!
007372D40  mov      x0, x22
007372D44  mov      x1, x19
007372D48  bl       #0x382bcb8 ;
007372D4C  stur     w24, [x22, #-8]
007372D50  cbz      w24, #0x7372d64
007372D54  ldr      x0, [x20]
007372D58  mov      v0.16b, v8.16b
007372D5C  mov      x1, xzr
007372D60  bl       #0x40e7f8c ; DG.Tweening.TweenSettingsExtensions$$AppendInterval
007372D64  ldr      x0, [x26]
007372D68  ldr      x22, [x19, #0x140]
007372D6C  bl       #0x382bfa0 ;
007372D70  ldr      x2, [x27]
007372D74  mov      x1, x21
007372D78  mov      x3, xzr
007372D7C  mov      x23, x0
007372D80  bl       #0x40e3a18 ; DG.Tweening.TweenCallback$$.ctor
007372D84  mov      x0, x22
007372D88  mov      x1, x23
007372D8C  mov      x2, xzr
007372D90  bl       #0x40f80c0 ; DG.Tweening.TweenSettingsExtensions$$AppendCallback
007372D94  ldr      x8, [x19, #0x148]
007372D98  add      w24, w24, #1
007372D9C  cbnz     x8, #0x7372d14
007372DA0  bl       #0x382bfb8 ;
007372DA4  ldr      x2, [x1, #0x60]
007372DA8  mov      x0, x19
007372DAC  ldp      x20, x19, [sp, #0x50]
007372DB0  ldp      x22, x21, [sp, #0x40]
007372DB4  ldp      x24, x23, [sp, #0x30]
007372DB8  ldp      x26, x25, [sp, #0x20]
007372DBC  ldp      x30, x27, [sp, #0x10]
007372DC0  ldr      d8, [sp], #0x60
007372DC4  br       x2
007372DC8  adrp     x8, #0x8f7d000
007372DCC  ldr      x0, [x20]
007372DD0  ldr      x8, [x8, #0x778]
007372DD4  ldp      x20, x19, [sp, #0x50]
007372DD8  ldp      x22, x21, [sp, #0x40]
007372DDC  ldp      x24, x23, [sp, #0x30]
007372DE0  ldr      x1, [x8]
007372DE4  ldp      x26, x25, [sp, #0x20]
007372DE8  ldp      x30, x27, [sp, #0x10]
007372DEC  ldr      d8, [sp], #0x60
007372DF0  b        #0x472093c ; DG.Tweening.TweenExtensions$$Play<object>
007372DF4  ldp      x20, x19, [sp, #0x50]
007372DF8  ldp      x22, x21, [sp, #0x40]
007372DFC  ldp      x24, x23, [sp, #0x30]
007372E00  ldp      x26, x25, [sp, #0x20]
007372E04  ldp      x30, x27, [sp, #0x10]
007372E08  ldr      d8, [sp], #0x60
007372E0C  ret

; HotFix.BattleResultViewMainModule$$OnClose
; RVA 0x7372E10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007372E10  stp      x30, x21, [sp, #-0x20]!
007372E14  stp      x20, x19, [sp, #0x10]
007372E18  adrp     x20, #0x95a7000
007372E1C  adrp     x21, #0x8f92000
007372E20  ldrb     w8, [x20, #0xa3f]
007372E24  ldr      x21, [x21, #0xf70]
007372E28  mov      x19, x0
007372E2C  tbnz     w8, #0, #0x7372e44
007372E30  adrp     x0, #0x8f92000
007372E34  ldr      x0, [x0, #0xf70]
007372E38  bl       #0x382bd14 ;
007372E3C  mov      w8, #1
007372E40  strb     w8, [x20, #0xa3f]
007372E44  ldr      x1, [x21]
007372E48  ldrb     w8, [x1, #0x53]
007372E4C  tbnz     w8, #5, #0x7372e78
007372E50  mov      x0, x19
007372E54  bl       #0x736b6b8 ; HotFix.BaseResulViewModule$$OnClose
007372E58  mov      x0, x19
007372E5C  bl       #0x7372608 ; HotFix.BattleResultViewMainModule$$ClearRecommendSkillItems
007372E60  add      x0, x19, #0x158
007372E64  str      xzr, [x19, #0x158]
007372E68  ldp      x20, x19, [sp, #0x10]
007372E6C  mov      x1, xzr
007372E70  ldp      x30, x21, [sp], #0x20
007372E74  b        #0x382bcb8 ;
007372E78  ldr      x2, [x1, #0x60]
007372E7C  mov      x0, x19
007372E80  ldp      x20, x19, [sp, #0x10]
007372E84  ldp      x30, x21, [sp], #0x20
007372E88  br       x2

; HotFix.BattleResultViewMainModule$$ClearRecommendSkillItems
; RVA 0x7372608; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007372608  stp      x30, x25, [sp, #-0x40]!
00737260C  stp      x24, x23, [sp, #0x10]
007372610  stp      x22, x21, [sp, #0x20]
007372614  stp      x20, x19, [sp, #0x30]
007372618  adrp     x20, #0x95a7000
00737261C  adrp     x21, #0x8f92000
007372620  ldrb     w8, [x20, #0xa40]
007372624  ldr      x21, [x21, #0xf00]
007372628  mov      x19, x0
00737262C  tbnz     w8, #0, #0x7372680
007372630  adrp     x0, #0x8f92000
007372634  ldr      x0, [x0, #0xf00]
007372638  bl       #0x382bd14 ;
00737263C  adrp     x0, #0x8ec1000
007372640  ldr      x0, [x0, #0x470]
007372644  bl       #0x382bd14 ;
007372648  adrp     x0, #0x8f92000
00737264C  ldr      x0, [x0, #0xf08]
007372650  bl       #0x382bd14 ;
007372654  adrp     x0, #0x8f92000
007372658  ldr      x0, [x0, #0xf10]
00737265C  bl       #0x382bd14 ;
007372660  adrp     x0, #0x8f92000
007372664  ldr      x0, [x0, #0xf18]
007372668  bl       #0x382bd14 ;
00737266C  adrp     x0, #0x8ebf000
007372670  ldr      x0, [x0, #0x460]
007372674  bl       #0x382bd14 ;
007372678  mov      w8, #1
00737267C  strb     w8, [x20, #0xa40]
007372680  ldr      x1, [x21]
007372684  ldrb     w8, [x1, #0x53]
007372688  tbnz     w8, #5, #0x737270c
00737268C  ldr      x0, [x19, #0x140]
007372690  add      x20, x19, #0x140
007372694  cbz      x0, #0x73726a4
007372698  mov      w1, wzr
00737269C  mov      x2, xzr
0073726A0  bl       #0x40e874c ; DG.Tweening.TweenExtensions$$Kill
0073726A4  mov      x0, x20
0073726A8  mov      x1, xzr
0073726AC  str      xzr, [x19, #0x140]
0073726B0  bl       #0x382bcb8 ;
0073726B4  ldr      x0, [x19, #0x148]
0073726B8  cbz      x0, #0x73728e8
0073726BC  adrp     x22, #0x8f92000
0073726C0  ldr      x22, [x22, #0xf18]
0073726C4  mov      w20, wzr
0073726C8  mov      x21, xzr
0073726CC  ldr      w2, [x0, #0x18]
0073726D0  cmp      w20, w2
0073726D4  b.ge     #0x7372728
0073726D8  ldr      x2, [x22]
0073726DC  mov      w1, w20
0073726E0  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0073726E4  cmp      x0, #0
0073726E8  csel     x21, x21, x0, eq
0073726EC  cbz      x0, #0x73726fc
0073726F0  cbz      x21, #0x73728e8
0073726F4  mov      x0, x21
0073726F8  bl       #0x736d4dc ; HotFix.BattleResultRecommendItem$$DeInit
0073726FC  ldr      x0, [x19, #0x148]
007372700  add      w20, w20, #1
007372704  cbnz     x0, #0x73726cc
007372708  b        #0x73728e8 ;
00737270C  ldr      x2, [x1, #0x60]
007372710  mov      x0, x19
007372714  ldp      x20, x19, [sp, #0x30]
007372718  ldp      x22, x21, [sp, #0x20]
00737271C  ldp      x24, x23, [sp, #0x10]
007372720  ldp      x30, x25, [sp], #0x40
007372724  br       x2
007372728  ldr      w8, [x0, #0x1c]
00737272C  cmp      w2, #1
007372730  add      w8, w8, #1
007372734  stp      wzr, w8, [x0, #0x18]
007372738  b.lt     #0x737274c
00737273C  ldr      x0, [x0, #0x10]
007372740  mov      w1, wzr
007372744  mov      x3, xzr
007372748  bl       #0x7c001d0 ; System.Array$$Clear
00737274C  ldr      x0, [x19, #0x118]
007372750  cbz      x0, #0x73728e8
007372754  mov      w1, #1
007372758  mov      x2, xzr
00737275C  bl       #0x8749d30 ; UnityEngine.Behaviour$$set_enabled
007372760  ldr      x0, [x19, #0x118]
007372764  cbz      x0, #0x73728e8
007372768  adrp     x8, #0x8ec1000
00737276C  ldr      x8, [x8, #0x470]
007372770  ldr      x1, [x8]
007372774  bl       #0x4556224 ; UnityEngine.Component$$GetComponent<object>
007372778  adrp     x25, #0x8ebf000
00737277C  ldr      x25, [x25, #0x460]
007372780  mov      x20, x0
007372784  ldr      x8, [x25]
007372788  ldr      w9, [x8, #0xe0]
00737278C  cbnz     w9, #0x7372798
007372790  mov      x0, x8
007372794  bl       #0x382be8c ;
007372798  mov      x0, x20
00737279C  mov      x1, xzr
0073727A0  mov      x2, xzr
0073727A4  bl       #0x874dafc ; UnityEngine.Object$$op_Inequality
0073727A8  tbz      w0, #0, #0x73727c0
0073727AC  cbz      x20, #0x73728e8
0073727B0  mov      w1, #1
0073727B4  mov      x0, x20
0073727B8  mov      x2, xzr
0073727BC  bl       #0x8749d30 ; UnityEngine.Behaviour$$set_enabled
0073727C0  ldr      x0, [x19, #0x120]
0073727C4  cbz      x0, #0x73728e8
0073727C8  mov      x1, xzr
0073727CC  bl       #0x874e0b8 ; UnityEngine.GameObject$$get_transform
0073727D0  cbz      x0, #0x73728e8
0073727D4  mov      x1, xzr
0073727D8  mov      x20, x0
0073727DC  bl       #0x875eb28 ; UnityEngine.Transform$$get_childCount
0073727E0  subs     w21, w0, #1
0073727E4  b.mi     #0x73728d4
0073727E8  mov      x0, x20
0073727EC  mov      w1, w21
0073727F0  mov      x2, xzr
0073727F4  bl       #0x875f190 ; UnityEngine.Transform$$GetChild
0073727F8  cbz      x0, #0x73728e8
0073727FC  mov      x1, xzr
007372800  mov      x22, x0
007372804  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007372808  ldr      x8, [x19, #0x128]
00737280C  cbz      x8, #0x73728e8
007372810  mov      x23, x0
007372814  mov      x0, x8
007372818  mov      x1, xzr
00737281C  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007372820  ldr      x8, [x25]
007372824  mov      x24, x0
007372828  ldr      w9, [x8, #0xe0]
00737282C  cbnz     w9, #0x7372838
007372830  mov      x0, x8
007372834  bl       #0x382be8c ;
007372838  mov      x0, x23
00737283C  mov      x1, x24
007372840  mov      x2, xzr
007372844  bl       #0x874dafc ; UnityEngine.Object$$op_Inequality
007372848  tbz      w0, #0, #0x73728cc
00737284C  mov      x0, x22
007372850  mov      x1, xzr
007372854  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007372858  ldr      x8, [x19, #0x130]
00737285C  cbz      x8, #0x73728e8
007372860  mov      x23, x0
007372864  mov      x0, x8
007372868  mov      x1, xzr
00737286C  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007372870  ldr      x8, [x25]
007372874  mov      x24, x0
007372878  ldr      w9, [x8, #0xe0]
00737287C  cbnz     w9, #0x7372888
007372880  mov      x0, x8
007372884  bl       #0x382be8c ;
007372888  mov      x0, x23
00737288C  mov      x1, x24
007372890  mov      x2, xzr
007372894  bl       #0x874dafc ; UnityEngine.Object$$op_Inequality
007372898  tbz      w0, #0, #0x73728cc
00737289C  mov      x0, x22
0073728A0  mov      x1, xzr
0073728A4  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
0073728A8  ldr      x8, [x25]
0073728AC  mov      x22, x0
0073728B0  ldr      w9, [x8, #0xe0]
0073728B4  cbnz     w9, #0x73728c0
0073728B8  mov      x0, x8
0073728BC  bl       #0x382be8c ;
0073728C0  mov      x0, x22
0073728C4  mov      x1, xzr
0073728C8  bl       #0x87533e4 ; UnityEngine.Object$$Destroy
0073728CC  subs     w21, w21, #1
0073728D0  b.pl     #0x73727e8
0073728D4  ldp      x20, x19, [sp, #0x30]
0073728D8  ldp      x22, x21, [sp, #0x20]
0073728DC  ldp      x24, x23, [sp, #0x10]
0073728E0  ldp      x30, x25, [sp], #0x40
0073728E4  ret
0073728E8  bl       #0x382bfb8 ;

; HotFix.BattleResultViewMainModule$$AnimationEnd
; RVA 0x7372E8C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007372E8C  sub      sp, sp, #0x40
007372E90  stp      x30, x23, [sp, #0x10]
007372E94  stp      x22, x21, [sp, #0x20]
007372E98  stp      x20, x19, [sp, #0x30]
007372E9C  adrp     x20, #0x95a7000
007372EA0  adrp     x21, #0x8f92000
007372EA4  ldrb     w8, [x20, #0xa41]
007372EA8  ldr      x21, [x21, #0xf78]
007372EAC  mov      x19, x0
007372EB0  tbnz     w8, #0, #0x7372f28
007372EB4  adrp     x0, #0x8ec1000
007372EB8  ldr      x0, [x0, #0x6e8]
007372EBC  bl       #0x382bd14 ;
007372EC0  adrp     x0, #0x8f92000
007372EC4  ldr      x0, [x0, #0xf78]
007372EC8  bl       #0x382bd14 ;
007372ECC  adrp     x0, #0x8f92000
007372ED0  ldr      x0, [x0, #0xf58]
007372ED4  bl       #0x382bd14 ;
007372ED8  adrp     x0, #0x8ef8000
007372EDC  ldr      x0, [x0, #0x1a8]
007372EE0  bl       #0x382bd14 ;
007372EE4  adrp     x0, #0x8ee1000
007372EE8  ldr      x0, [x0, #0x5e0]
007372EEC  bl       #0x382bd14 ;
007372EF0  adrp     x0, #0x8ee6000
007372EF4  ldr      x0, [x0, #0x680]
007372EF8  bl       #0x382bd14 ;
007372EFC  adrp     x0, #0x8ebf000
007372F00  ldr      x0, [x0, #0xba0]
007372F04  bl       #0x382bd14 ;
007372F08  adrp     x0, #0x8f6b000
007372F0C  ldr      x0, [x0, #0x680]
007372F10  bl       #0x382bd14 ;
007372F14  adrp     x0, #0x8edf000
007372F18  ldr      x0, [x0, #0x8a8]
007372F1C  bl       #0x382bd14 ;
007372F20  mov      w8, #1
007372F24  strb     w8, [x20, #0xa41]
007372F28  ldr      x1, [x21]
007372F2C  ldrb     w8, [x1, #0x53]
007372F30  tbnz     w8, #5, #0x7372fc8
007372F34  str      wzr, [sp, #0xc]
007372F38  ldr      x1, [x19, #0x90]
007372F3C  cbz      x1, #0x7372fe4
007372F40  ldr      w8, [x1, #0x18]
007372F44  ldr      x20, [x19, #0x78]
007372F48  cmp      w8, #1
007372F4C  b.lt     #0x7372fe8
007372F50  adrp     x8, #0x8ec1000
007372F54  ldr      x8, [x8, #0x6e8]
007372F58  ldr      x0, [x8]
007372F5C  bl       #0x382bfa0 ;
007372F60  adrp     x8, #0x8f92000
007372F64  ldr      x8, [x8, #0xf58]
007372F68  mov      x1, x19
007372F6C  mov      x3, xzr
007372F70  mov      x21, x0
007372F74  ldr      x2, [x8]
007372F78  bl       #0x7ade578 ; System.Action$$.ctor
007372F7C  cbz      x20, #0x73731e8
007372F80  adrp     x22, #0x95a7000
007372F84  ldrb     w8, [x22, #0xa6b]
007372F88  cbnz     w8, #0x7372fa0
007372F8C  adrp     x0, #0x8f92000
007372F90  ldr      x0, [x0, #0xf80]
007372F94  bl       #0x382bd14 ;
007372F98  mov      w8, #1
007372F9C  strb     w8, [x22, #0xa6b]
007372FA0  adrp     x8, #0x8f92000
007372FA4  ldr      x8, [x8, #0xf80]
007372FA8  ldr      x2, [x8]
007372FAC  ldrb     w8, [x2, #0x53]
007372FB0  tbnz     w8, #5, #0x737300c
007372FB4  str      x21, [x20, #0xa0]!
007372FB8  mov      x0, x20
007372FBC  mov      x1, x21
007372FC0  bl       #0x382bcb8 ;
007372FC4  b        #0x737301c ;
007372FC8  ldr      x2, [x1, #0x60]
007372FCC  mov      x0, x19
007372FD0  ldp      x20, x19, [sp, #0x30]
007372FD4  ldp      x22, x21, [sp, #0x20]
007372FD8  ldp      x30, x23, [sp, #0x10]
007372FDC  add      sp, sp, #0x40
007372FE0  br       x2
007372FE4  ldr      x20, [x19, #0x78]
007372FE8  cbz      x20, #0x73731e8
007372FEC  mov      w3, #1
007372FF0  mov      x0, x20
007372FF4  mov      w2, wzr
007372FF8  mov      x4, xzr
007372FFC  bl       #0x74a5334 ; HotFix.CommonPopShowCtrl$$ShowReward
007373000  mov      x0, x19
007373004  bl       #0x7372bf8 ; HotFix.BattleResultViewMainModule$$PlayRecommendSkillAnim
007373008  b        #0x7373038 ;
00737300C  ldr      x8, [x2, #0x60]
007373010  mov      x0, x20
007373014  mov      x1, x21
007373018  blr      x8
00737301C  ldr      x0, [x19, #0x78]
007373020  cbz      x0, #0x73731e8
007373024  ldr      x1, [x19, #0x90]
007373028  mov      w3, #1
00737302C  mov      w2, wzr
007373030  mov      x4, xzr
007373034  bl       #0x74a5334 ; HotFix.CommonPopShowCtrl$$ShowReward
007373038  adrp     x20, #0x8ee1000
00737303C  ldr      x20, [x20, #0x5e0]
007373040  ldr      x0, [x20]
007373044  ldr      w8, [x0, #0xe0]
007373048  cbnz     w8, #0x7373050
00737304C  bl       #0x382be8c ;
007373050  adrp     x21, #0x9591000
007373054  ldrb     w8, [x21, #0x5bb]
007373058  cbnz     w8, #0x7373070
00737305C  adrp     x0, #0x8ee1000
007373060  ldr      x0, [x0, #0x5e0]
007373064  bl       #0x382bd14 ;
007373068  mov      w8, #1
00737306C  strb     w8, [x21, #0x5bb]
007373070  ldr      x0, [x20]
007373074  ldr      w8, [x0, #0xe0]
007373078  cbnz     w8, #0x7373084
00737307C  bl       #0x382be8c ;
007373080  ldr      x0, [x20]
007373084  ldr      x8, [x0, #0xb8]
007373088  adrp     x9, #0x8ef8000
00737308C  ldr      x9, [x9, #0x1a8]
007373090  ldr      x0, [x8, #0x18]
007373094  ldr      x2, [x9]
007373098  mov      w1, #0x69
00737309C  bl       #0x462beb8 ; HotFix.FrameworkExpand$$GetDataModule<object>
0073730A0  adrp     x8, #0x8ee6000
0073730A4  ldr      x8, [x8, #0x680]
0073730A8  ldr      x0, [x8]
0073730AC  ldr      w8, [x0, #0xe0]
0073730B0  cbnz     w8, #0x73730b8
0073730B4  bl       #0x382be8c ;
0073730B8  mov      x0, xzr
0073730BC  bl       #0x7091c90 ; HotFix.Game$$get_Table
0073730C0  cbz      x0, #0x73731ec
0073730C4  mov      w1, #1
0073730C8  mov      x2, xzr
0073730CC  bl       #0x64cfd04 ; LocalModels.LocalModelManager$$GetExp_expGlobal
0073730D0  mov      x20, x0
0073730D4  cbz      x0, #0x73731f0
0073730D8  adrp     x21, #0x95a7000
0073730DC  ldrb     w8, [x21, #0xa64]
0073730E0  cbnz     w8, #0x73730f8
0073730E4  adrp     x0, #0x8f37000
0073730E8  ldr      x0, [x0, #0xea0]
0073730EC  bl       #0x382bd14 ;
0073730F0  mov      w8, #1
0073730F4  strb     w8, [x21, #0xa64]
0073730F8  adrp     x8, #0x8f37000
0073730FC  ldr      x8, [x8, #0xea0]
007373100  ldr      x1, [x8]
007373104  ldrb     w8, [x1, #0x53]
007373108  tbnz     w8, #5, #0x7373114
00737310C  ldr      w21, [x20, #0x24]
007373110  b        #0x7373124 ;
007373114  ldr      x8, [x1, #0x60]
007373118  mov      x0, x20
00737311C  blr      x8
007373120  mov      w21, w0
007373124  ldr      x0, [x19, #0xd0]
007373128  cbz      x0, #0x73731f4
00737312C  scvtf    s0, w21
007373130  fmov     s1, wzr
007373134  fdiv     s0, s1, s0
007373138  mov      x1, xzr
00737313C  bl       #0x64c1dbc ; TipsProgressCtrl$$set_Value
007373140  adrp     x23, #0x8ebf000
007373144  ldr      x20, [x19, #0xd0]
007373148  ldr      x23, [x23, #0xba0]
00737314C  str      wzr, [sp, #8]
007373150  ldr      x0, [x23]
007373154  add      x1, sp, #8
007373158  bl       #0x382be94 ;
00737315C  mov      x22, x0
007373160  ldr      x0, [x23]
007373164  str      w21, [sp, #4]
007373168  add      x1, sp, #4
00737316C  bl       #0x382be94 ;
007373170  adrp     x8, #0x8edf000
007373174  ldr      x8, [x8, #0x8a8]
007373178  mov      x2, x0
00737317C  ldr      x0, [x8]
007373180  mov      x1, x22
007373184  mov      x3, xzr
007373188  bl       #0x79e2794 ; System.String$$Format
00737318C  mov      x1, x0
007373190  cbz      x20, #0x73731f8
007373194  mov      x0, x20
007373198  mov      x2, xzr
00737319C  bl       #0x64c1e4c ; ProgressTextCtrl$$SetText
0073731A0  ldr      x19, [x19, #0xd8]
0073731A4  mov      w8, #1
0073731A8  str      w8, [sp, #0xc]
0073731AC  add      x0, sp, #0xc
0073731B0  mov      x1, xzr
0073731B4  bl       #0x7bd22a0 ; System.Int32$$ToString
0073731B8  mov      x1, x0
0073731BC  cbz      x19, #0x73731fc
0073731C0  ldr      x8, [x19]
0073731C4  ldr      x9, [x8, #0x5e8]
0073731C8  ldr      x2, [x8, #0x5f0]
0073731CC  mov      x0, x19
0073731D0  blr      x9
0073731D4  ldp      x20, x19, [sp, #0x30]
0073731D8  ldp      x22, x21, [sp, #0x20]
0073731DC  ldp      x30, x23, [sp, #0x10]
0073731E0  add      sp, sp, #0x40
0073731E4  ret
0073731E8  bl       #0x382bfb8 ;
0073731EC  bl       #0x382bfb8 ;
0073731F0  bl       #0x382bfb8 ;
0073731F4  bl       #0x382bfb8 ;
0073731F8  bl       #0x382bfb8 ;
0073731FC  bl       #0x382bfb8 ;
007373200  b        #0x7373228 ;
007373204  b        #0x7373228 ;
007373208  b        #0x7373228 ;
00737320C  b        #0x7373228 ;
007373210  b        #0x7373228 ;
007373214  b        #0x7373228 ;
007373218  b        #0x7373228 ;
00737321C  b        #0x7373228 ;
007373220  b        #0x7373228 ;
007373224  b        #0x7373228 ;
007373228  mov      x19, x0
00737322C  cmp      w1, #1
007373230  b.ne     #0x73732dc
007373234  mov      x0, x19
007373238  bl       #0x89eda50 ;
00737323C  mov      x19, x0
007373240  adrp     x0, #0x8ebf000
007373244  ldr      x0, [x0, #0xc70]
007373248  bl       #0x382bd28 ;
00737324C  ldr      x8, [x19]
007373250  ldr      x1, [x8]
007373254  bl       #0x382c3e4 ;
007373258  tbz      w0, #0, #0x73732b4
00737325C  ldr      x19, [x19]
007373260  bl       #0x89eda60 ;
007373264  adrp     x0, #0x8ee1000
007373268  ldr      x0, [x0, #0x6e8]
00737326C  bl       #0x382bd28 ;
007373270  ldr      w8, [x0, #0xe0]
007373274  cbnz     w8, #0x737327c
007373278  bl       #0x382be8c ;
00737327C  adrp     x0, #0x8f70000
007373280  ldr      x0, [x0, #0x368]
007373284  bl       #0x382bd28 ;
007373288  mov      x20, x0
00737328C  adrp     x0, #0x8f92000
007373290  ldr      x0, [x0, #0xef0]
007373294  bl       #0x382bd28 ;
007373298  mov      x2, x0
00737329C  mov      w3, #0x26e
0073732A0  mov      x0, x19
0073732A4  mov      x1, x20
0073732A8  mov      x4, xzr
0073732AC  bl       #0x799724c ; Logger$$LogException
0073732B0  b        #0x73731d4 ;
0073732B4  mov      w0, #8
0073732B8  bl       #0x89eda70 ;
0073732BC  ldr      x8, [x19]
0073732C0  str      x8, [x0]
0073732C4  adrp     x1, #0x89f3000
0073732C8  add      x1, x1, #0xf98
0073732CC  mov      x2, xzr
0073732D0  bl       #0x89eda80 ;
0073732D4  mov      x19, x0
0073732D8  bl       #0x89eda60 ;
0073732DC  mov      x0, x19
0073732E0  bl       #0x3b56bfc ;
0073732E4  bl       #0x3442448 ;

; HotFix.BattleResultViewMainModule$$OnClickClose
; RVA 0x73732E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0073732E8  stp      x30, x21, [sp, #-0x20]!
0073732EC  stp      x20, x19, [sp, #0x10]
0073732F0  adrp     x20, #0x95a7000
0073732F4  adrp     x21, #0x8f92000
0073732F8  ldrb     w8, [x20, #0xa42]
0073732FC  ldr      x21, [x21, #0xe30]
007373300  mov      x19, x0
007373304  tbnz     w8, #0, #0x7373328
007373308  adrp     x0, #0x8f92000
00737330C  ldr      x0, [x0, #0xe30]
007373310  bl       #0x382bd14 ;
007373314  adrp     x0, #0x8ee1000
007373318  ldr      x0, [x0, #0x5e0]
00737331C  bl       #0x382bd14 ;
007373320  mov      w8, #1
007373324  strb     w8, [x20, #0xa42]
007373328  ldr      x1, [x21]
00737332C  ldrb     w8, [x1, #0x53]
007373330  tbnz     w8, #5, #0x7373348
007373334  ldrb     w8, [x19, #0x150]
007373338  cbz      w8, #0x737335c
00737333C  ldp      x20, x19, [sp, #0x10]
007373340  ldp      x30, x21, [sp], #0x20
007373344  ret
007373348  ldr      x2, [x1, #0x60]
00737334C  mov      x0, x19
007373350  ldp      x20, x19, [sp, #0x10]
007373354  ldp      x30, x21, [sp], #0x20
007373358  br       x2
00737335C  mov      w8, #1
007373360  strb     w8, [x19, #0x150]
007373364  adrp     x20, #0x8ee1000
007373368  ldr      x20, [x20, #0x5e0]
00737336C  ldr      x0, [x20]
007373370  ldr      w8, [x0, #0xe0]
007373374  cbnz     w8, #0x737337c
007373378  bl       #0x382be8c ;
00737337C  adrp     x21, #0x9591000
007373380  ldrb     w8, [x21, #0x59d]
007373384  cbnz     w8, #0x737339c
007373388  adrp     x0, #0x8ee1000
00737338C  ldr      x0, [x0, #0x5e0]
007373390  bl       #0x382bd14 ;
007373394  mov      w8, #1
007373398  strb     w8, [x21, #0x59d]
00737339C  ldr      x0, [x20]
0073733A0  ldr      w8, [x0, #0xe0]
0073733A4  cbnz     w8, #0x73733b0
0073733A8  bl       #0x382be8c ;
0073733AC  ldr      x0, [x20]
0073733B0  ldr      x8, [x0, #0xb8]
0073733B4  mov      w1, #0x17
0073733B8  mov      x2, xzr
0073733BC  ldr      x0, [x8, #0x28]
0073733C0  bl       #0x7271c1c ; HotFix.FrameworkExpand$$CloseView
0073733C4  mov      x0, x19
0073733C8  ldp      x20, x19, [sp, #0x10]
0073733CC  ldp      x30, x21, [sp], #0x20
0073733D0  b        #0x736b72c ; HotFix.BaseResulViewModule$$DoCloseView

; HotFix.BattleResultViewMainModule$$OnClickFunctionRecommend
; RVA 0x73733D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0073733D4  sub      sp, sp, #0x40
0073733D8  stp      x30, x23, [sp, #0x10]
0073733DC  stp      x22, x21, [sp, #0x20]
0073733E0  stp      x20, x19, [sp, #0x30]
0073733E4  adrp     x21, #0x95a7000
0073733E8  adrp     x22, #0x8f92000
0073733EC  ldrb     w8, [x21, #0xa43]
0073733F0  ldr      x22, [x22, #0xf28]
0073733F4  mov      w20, w1
0073733F8  mov      x19, x0
0073733FC  tbnz     w8, #0, #0x7373498
007373400  adrp     x0, #0x8f92000
007373404  ldr      x0, [x0, #0xf28]
007373408  bl       #0x382bd14 ;
00737340C  adrp     x0, #0x8ebf000
007373410  ldr      x0, [x0, #0xf08]
007373414  bl       #0x382bd14 ;
007373418  adrp     x0, #0x8f7b000
00737341C  ldr      x0, [x0, #0x460]
007373420  bl       #0x382bd14 ;
007373424  adrp     x0, #0x8ee1000
007373428  ldr      x0, [x0, #0x5e0]
00737342C  bl       #0x382bd14 ;
007373430  adrp     x0, #0x8ebf000
007373434  ldr      x0, [x0, #0xba0]
007373438  bl       #0x382bd14 ;
00737343C  adrp     x0, #0x8f92000
007373440  ldr      x0, [x0, #0xf88]
007373444  bl       #0x382bd14 ;
007373448  adrp     x0, #0x8ee1000
00737344C  ldr      x0, [x0, #0x6e8]
007373450  bl       #0x382bd14 ;
007373454  adrp     x0, #0x8ebf000
007373458  ldr      x0, [x0, #0x3a8]
00737345C  bl       #0x382bd14 ;
007373460  adrp     x0, #0x8f92000
007373464  ldr      x0, [x0, #0xf90]
007373468  bl       #0x382bd14 ;
00737346C  adrp     x0, #0x8f92000
007373470  ldr      x0, [x0, #0xf98]
007373474  bl       #0x382bd14 ;
007373478  adrp     x0, #0x8f92000
00737347C  ldr      x0, [x0, #0xfa0]
007373480  bl       #0x382bd14 ;
007373484  adrp     x0, #0x8f92000
007373488  ldr      x0, [x0, #0xef0]
00737348C  bl       #0x382bd14 ;
007373490  mov      w8, #1
007373494  strb     w8, [x21, #0xa43]
007373498  ldr      x2, [x22]
00737349C  ldrb     w8, [x2, #0x53]
0073734A0  tbnz     w8, #5, #0x73735e4
0073734A4  ldrb     w8, [x19, #0x150]
0073734A8  cbnz     w8, #0x73736ec
0073734AC  cmp      w20, #1
0073734B0  b.lt     #0x7373604
0073734B4  adrp     x8, #0x8ebf000
0073734B8  ldr      x8, [x8, #0x3a8]
0073734BC  ldr      x0, [x8]
0073734C0  adrp     x8, #0x8f92000
0073734C4  ldr      x8, [x8, #0xf88]
0073734C8  ldr      w9, [x0, #0xe0]
0073734CC  ldr      x21, [x8]
0073734D0  cbnz     w9, #0x73734d8
0073734D4  bl       #0x382be8c ;
0073734D8  mov      x0, x21
0073734DC  mov      x1, xzr
0073734E0  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0073734E4  adrp     x23, #0x8ebf000
0073734E8  ldr      x23, [x23, #0xba0]
0073734EC  mov      x21, x0
0073734F0  add      x1, sp, #0xc
0073734F4  str      w20, [sp, #0xc]
0073734F8  ldr      x0, [x23]
0073734FC  bl       #0x382be94 ;
007373500  adrp     x8, #0x8ebf000
007373504  ldr      x8, [x8, #0xf08]
007373508  mov      x22, x0
00737350C  ldr      x8, [x8]
007373510  ldr      w9, [x8, #0xe0]
007373514  cbnz     w9, #0x7373520
007373518  mov      x0, x8
00737351C  bl       #0x382be8c ;
007373520  mov      x0, x21
007373524  mov      x1, x22
007373528  mov      x2, xzr
00737352C  bl       #0x7c14160 ; System.Enum$$IsDefined
007373530  tbz      w0, #0, #0x7373604
007373534  adrp     x21, #0x8ee1000
007373538  ldr      x21, [x21, #0x5e0]
00737353C  ldr      x0, [x21]
007373540  ldr      w8, [x0, #0xe0]
007373544  cbnz     w8, #0x737354c
007373548  bl       #0x382be8c ;
00737354C  adrp     x22, #0x9591000
007373550  ldrb     w8, [x22, #0x5bb]
007373554  cbnz     w8, #0x737356c
007373558  adrp     x0, #0x8ee1000
00737355C  ldr      x0, [x0, #0x5e0]
007373560  bl       #0x382bd14 ;
007373564  mov      w8, #1
007373568  strb     w8, [x22, #0x5bb]
00737356C  ldr      x0, [x21]
007373570  ldr      w8, [x0, #0xe0]
007373574  cbnz     w8, #0x7373580
007373578  bl       #0x382be8c ;
00737357C  ldr      x0, [x21]
007373580  ldr      x8, [x0, #0xb8]
007373584  ldr      x0, [x8, #0x18]
007373588  cbz      x0, #0x7373670
00737358C  adrp     x8, #0x8f7b000
007373590  ldr      x8, [x8, #0x460]
007373594  mov      w1, #0x65
007373598  ldr      x2, [x8]
00737359C  bl       #0x462beb8 ; HotFix.FrameworkExpand$$GetDataModule<object>
0073735A0  cbz      x0, #0x7373670
0073735A4  adrp     x22, #0x95a7000
0073735A8  ldrb     w8, [x22, #0xa6c]
0073735AC  mov      x21, x0
0073735B0  cbnz     w8, #0x73735c8
0073735B4  adrp     x0, #0x8f82000
0073735B8  ldr      x0, [x0, #0x970]
0073735BC  bl       #0x382bd14 ;
0073735C0  mov      w8, #1
0073735C4  strb     w8, [x22, #0xa6c]
0073735C8  adrp     x8, #0x8f82000
0073735CC  ldr      x8, [x8, #0x970]
0073735D0  ldr      x2, [x8]
0073735D4  ldrb     w8, [x2, #0x53]
0073735D8  tbnz     w8, #5, #0x7373700
0073735DC  str      w20, [x21, #0x18]
0073735E0  b        #0x73736e4 ;
0073735E4  ldr      x3, [x2, #0x60]
0073735E8  mov      x0, x19
0073735EC  mov      w1, w20
0073735F0  ldp      x20, x19, [sp, #0x30]
0073735F4  ldp      x22, x21, [sp, #0x20]
0073735F8  ldp      x30, x23, [sp, #0x10]
0073735FC  add      sp, sp, #0x40
007373600  br       x3
007373604  adrp     x8, #0x8ebf000
007373608  ldr      x8, [x8, #0xba0]
00737360C  add      x1, sp, #4
007373610  str      w20, [sp, #4]
007373614  ldr      x0, [x8]
007373618  bl       #0x382be94 ;
00737361C  adrp     x8, #0x8f92000
007373620  ldr      x8, [x8, #0xf98]
007373624  mov      x1, x0
007373628  mov      x2, xzr
00737362C  ldr      x8, [x8]
007373630  mov      x0, x8
007373634  bl       #0x79d140c ; System.String$$Format
007373638  adrp     x8, #0x8ee1000
00737363C  ldr      x8, [x8, #0x6e8]
007373640  mov      x20, x0
007373644  ldr      x8, [x8]
007373648  ldr      w9, [x8, #0xe0]
00737364C  cbnz     w9, #0x7373658
007373650  mov      x0, x8
007373654  bl       #0x382be8c ;
007373658  adrp     x8, #0x8f92000
00737365C  adrp     x9, #0x8f92000
007373660  ldr      x8, [x8, #0xf90]
007373664  ldr      x9, [x9, #0xef0]
007373668  mov      w3, #0x293
00737366C  b        #0x73736d0 ;
007373670  ldr      x0, [x23]
007373674  add      x1, sp, #8
007373678  str      w20, [sp, #8]
00737367C  bl       #0x382be94 ;
007373680  adrp     x8, #0x8f92000
007373684  ldr      x8, [x8, #0xfa0]
007373688  mov      x1, x0
00737368C  mov      x2, xzr
007373690  ldr      x8, [x8]
007373694  mov      x0, x8
007373698  bl       #0x79d140c ; System.String$$Format
00737369C  adrp     x8, #0x8ee1000
0073736A0  ldr      x8, [x8, #0x6e8]
0073736A4  mov      x20, x0
0073736A8  ldr      x8, [x8]
0073736AC  ldr      w9, [x8, #0xe0]
0073736B0  cbnz     w9, #0x73736bc
0073736B4  mov      x0, x8
0073736B8  bl       #0x382be8c ;
0073736BC  adrp     x8, #0x8f92000
0073736C0  adrp     x9, #0x8f92000
0073736C4  ldr      x8, [x8, #0xf90]
0073736C8  ldr      x9, [x9, #0xef0]
0073736CC  mov      w3, #0x28e
0073736D0  ldr      x1, [x8]
0073736D4  ldr      x2, [x9]
0073736D8  mov      x0, x20
0073736DC  mov      x4, xzr
0073736E0  bl       #0x7997754 ; Logger$$LogError
0073736E4  mov      x0, x19
0073736E8  bl       #0x73732e8 ; HotFix.BattleResultViewMainModule$$OnClickClose
0073736EC  ldp      x20, x19, [sp, #0x30]
0073736F0  ldp      x22, x21, [sp, #0x20]
0073736F4  ldp      x30, x23, [sp, #0x10]
0073736F8  add      sp, sp, #0x40
0073736FC  ret
007373700  ldr      x8, [x2, #0x60]
007373704  mov      x0, x21
007373708  mov      w1, w20
00737370C  blr      x8
007373710  b        #0x73736e4 ;

; HotFix.BattleResultViewMainModule$$OnCloseView
; RVA 0x7373714; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007373714  stp      x30, x21, [sp, #-0x20]!
007373718  stp      x20, x19, [sp, #0x10]
00737371C  adrp     x20, #0x95a7000
007373720  adrp     x21, #0x8f92000
007373724  ldrb     w8, [x20, #0xa44]
007373728  ldr      x21, [x21, #0xfa8]
00737372C  mov      x19, x0
007373730  tbnz     w8, #0, #0x7373754
007373734  adrp     x0, #0x8f92000
007373738  ldr      x0, [x0, #0xfa8]
00737373C  bl       #0x382bd14 ;
007373740  adrp     x0, #0x8ee1000
007373744  ldr      x0, [x0, #0x5e0]
007373748  bl       #0x382bd14 ;
00737374C  mov      w8, #1
007373750  strb     w8, [x20, #0xa44]
007373754  ldr      x1, [x21]
007373758  ldrb     w8, [x1, #0x53]
00737375C  tbnz     w8, #5, #0x73737d0
007373760  ldrb     w8, [x19, #0x160]
007373764  cbz      w8, #0x73737e4
007373768  adrp     x19, #0x8ee1000
00737376C  ldr      x19, [x19, #0x5e0]
007373770  ldr      x0, [x19]
007373774  ldr      w8, [x0, #0xe0]
007373778  cbnz     w8, #0x7373780
00737377C  bl       #0x382be8c ;
007373780  adrp     x20, #0x9591000
007373784  ldrb     w8, [x20, #0x5ba]
007373788  cbnz     w8, #0x73737a0
00737378C  adrp     x0, #0x8ee1000
007373790  ldr      x0, [x0, #0x5e0]
007373794  bl       #0x382bd14 ;
007373798  mov      w8, #1
00737379C  strb     w8, [x20, #0x5ba]
0073737A0  ldr      x0, [x19]
0073737A4  ldr      w8, [x0, #0xe0]
0073737A8  cbnz     w8, #0x73737b4
0073737AC  bl       #0x382be8c ;
0073737B0  ldr      x0, [x19]
0073737B4  ldr      x8, [x0, #0xb8]
0073737B8  ldp      x20, x19, [sp, #0x10]
0073737BC  mov      w1, #0x9b
0073737C0  mov      x2, xzr
0073737C4  ldr      x0, [x8, #0x10]
0073737C8  ldp      x30, x21, [sp], #0x20
0073737CC  b        #0x7263220 ; HotFix.FrameworkExpand$$DispatchNow
0073737D0  ldr      x2, [x1, #0x60]
0073737D4  mov      x0, x19
0073737D8  ldp      x20, x19, [sp, #0x10]
0073737DC  ldp      x30, x21, [sp], #0x20
0073737E0  br       x2
0073737E4  ldp      x20, x19, [sp, #0x10]
0073737E8  ldp      x30, x21, [sp], #0x20
0073737EC  ret

; HotFix.BattleResultViewMainModule$$Debug
; RVA 0x73737F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0073737F0  stp      x29, x30, [sp, #-0x60]!
0073737F4  stp      x28, x27, [sp, #0x10]
0073737F8  stp      x26, x25, [sp, #0x20]
0073737FC  stp      x24, x23, [sp, #0x30]
007373800  stp      x22, x21, [sp, #0x40]
007373804  stp      x20, x19, [sp, #0x50]
007373808  adrp     x19, #0x95a7000
00737380C  adrp     x21, #0x8f92000
007373810  ldrb     w8, [x19, #0xa45]
007373814  ldr      x21, [x21, #0xfb0]
007373818  mov      x20, x0
00737381C  tbnz     w8, #0, #0x7373870
007373820  adrp     x0, #0x8f92000
007373824  ldr      x0, [x0, #0xfb0]
007373828  bl       #0x382bd14 ;
00737382C  adrp     x0, #0x8ee1000
007373830  ldr      x0, [x0, #0x5e0]
007373834  bl       #0x382bd14 ;
007373838  adrp     x0, #0x8f74000
00737383C  ldr      x0, [x0, #0xb38]
007373840  bl       #0x382bd14 ;
007373844  adrp     x0, #0x8f74000
007373848  ldr      x0, [x0, #0xc40]
00737384C  bl       #0x382bd14 ;
007373850  adrp     x0, #0x8f92000
007373854  ldr      x0, [x0, #0xfb8]
007373858  bl       #0x382bd14 ;
00737385C  adrp     x0, #0x8f4b000
007373860  ldr      x0, [x0, #0xb08]
007373864  bl       #0x382bd14 ;
007373868  mov      w8, #1
00737386C  strb     w8, [x19, #0xa45]
007373870  ldr      x1, [x21]
007373874  ldrb     w8, [x1, #0x53]
007373878  tbnz     w8, #5, #0x737394c
00737387C  adrp     x23, #0x8ee1000
007373880  ldr      x23, [x23, #0x5e0]
007373884  ldr      x0, [x23]
007373888  ldr      w8, [x0, #0xe0]
00737388C  cbnz     w8, #0x7373894
007373890  bl       #0x382be8c ;
007373894  adrp     x24, #0x9591000
007373898  ldrb     w8, [x24, #0x59d]
00737389C  cbnz     w8, #0x73738b4
0073738A0  adrp     x0, #0x8ee1000
0073738A4  ldr      x0, [x0, #0x5e0]
0073738A8  bl       #0x382bd14 ;
0073738AC  mov      w8, #1
0073738B0  strb     w8, [x24, #0x59d]
0073738B4  ldr      x0, [x23]
0073738B8  ldr      w8, [x0, #0xe0]
0073738BC  cbnz     w8, #0x73738c8
0073738C0  bl       #0x382be8c ;
0073738C4  ldr      x0, [x23]
0073738C8  ldr      x8, [x0, #0xb8]
0073738CC  mov      w1, #0x17
0073738D0  mov      x2, xzr
0073738D4  ldr      x0, [x8, #0x28]
0073738D8  bl       #0x7267030 ; HotFix.FrameworkExpand$$IsOpenedOrLoading
0073738DC  tbz      w0, #0, #0x7373970
0073738E0  ldr      x0, [x23]
0073738E4  ldr      w8, [x0, #0xe0]
0073738E8  cbnz     w8, #0x73738f0
0073738EC  bl       #0x382be8c ;
0073738F0  ldrb     w8, [x24, #0x59d]
0073738F4  cbnz     w8, #0x737390c
0073738F8  adrp     x0, #0x8ee1000
0073738FC  ldr      x0, [x0, #0x5e0]
007373900  bl       #0x382bd14 ;
007373904  mov      w8, #1
007373908  strb     w8, [x24, #0x59d]
00737390C  ldr      x0, [x23]
007373910  ldr      w8, [x0, #0xe0]
007373914  cbnz     w8, #0x7373920
007373918  bl       #0x382be8c ;
00737391C  ldr      x0, [x23]
007373920  ldr      x8, [x0, #0xb8]
007373924  ldp      x20, x19, [sp, #0x50]
007373928  ldp      x22, x21, [sp, #0x40]
00737392C  ldp      x24, x23, [sp, #0x30]
007373930  ldr      x0, [x8, #0x28]
007373934  ldp      x26, x25, [sp, #0x20]
007373938  ldp      x28, x27, [sp, #0x10]
00737393C  mov      w1, #0x17
007373940  mov      x2, xzr
007373944  ldp      x29, x30, [sp], #0x60
007373948  b        #0x7271c1c ; HotFix.FrameworkExpand$$CloseView
00737394C  ldr      x2, [x1, #0x60]
007373950  mov      x0, x20
007373954  ldp      x20, x19, [sp, #0x50]
007373958  ldp      x22, x21, [sp, #0x40]
00737395C  ldp      x24, x23, [sp, #0x30]
007373960  ldp      x26, x25, [sp, #0x20]
007373964  ldp      x28, x27, [sp, #0x10]
007373968  ldp      x29, x30, [sp], #0x60
00737396C  br       x2
007373970  adrp     x8, #0x8f74000
007373974  ldr      x8, [x8, #0xc40]
007373978  ldr      x0, [x8]
00737397C  bl       #0x382bfa0 ;
007373980  mov      x1, xzr
007373984  mov      x19, x0
007373988  bl       #0x7373ea0 ; HotFix.BattleResultViewMainModule.OpenData$$.ctor
00737398C  cbz      x19, #0x7373c14
007373990  mov      w8, #1
007373994  movi     v0.2s, #1
007373998  strb     w8, [x19, #0x10]
00737399C  stur     d0, [x19, #0x14]
0073739A0  strb     w8, [x19, #0x20]
0073739A4  cbz      x20, #0x7373c14
0073739A8  adrp     x8, #0x8f74000
0073739AC  ldr      x8, [x8, #0xb38]
0073739B0  mov      x0, x20
0073739B4  ldr      x1, [x8]
0073739B8  bl       #0x4db1cf0 ; System.Collections.Generic.List<object>$$ToArray
0073739BC  mov      x1, x0
0073739C0  mov      x0, x19
0073739C4  str      x1, [x0, #0x38]!
0073739C8  bl       #0x382bcb8 ;
0073739CC  adrp     x8, #0x8f92000
0073739D0  ldr      x8, [x8, #0xfb8]
0073739D4  mov      w1, #2
0073739D8  ldr      x0, [x8]
0073739DC  bl       #0x382bdfc ;
0073739E0  mov      x20, x19
0073739E4  str      x0, [x20, #0x40]!
0073739E8  mov      x1, x0
0073739EC  mov      x0, x20
0073739F0  bl       #0x382bcb8 ;
0073739F4  adrp     x27, #0x8f4b000
0073739F8  ldr      x21, [x20]
0073739FC  ldr      x27, [x27, #0xb08]
007373A00  ldr      x0, [x27]
007373A04  bl       #0x382bfa0 ;
007373A08  mov      x1, xzr
007373A0C  mov      x22, x0
007373A10  bl       #0x6da02a4 ; Proto.Common.RewardDto$$.ctor
007373A14  cbz      x22, #0x7373c14
007373A18  adrp     x25, #0x95a2000
007373A1C  ldrb     w8, [x25, #0x346]
007373A20  cbnz     w8, #0x7373a38
007373A24  adrp     x0, #0x8f59000
007373A28  ldr      x0, [x0, #0x168]
007373A2C  bl       #0x382bd14 ;
007373A30  mov      w8, #1
007373A34  strb     w8, [x25, #0x346]
007373A38  adrp     x28, #0x8f59000
007373A3C  ldr      x28, [x28, #0x168]
007373A40  ldr      x2, [x28]
007373A44  ldrb     w8, [x2, #0x53]
007373A48  tbnz     w8, #5, #0x7373a58
007373A4C  mov      w8, #1
007373A50  str      w8, [x22, #0x1c]
007373A54  b        #0x7373a68 ;
007373A58  ldr      x8, [x2, #0x60]
007373A5C  mov      w1, #1
007373A60  mov      x0, x22
007373A64  blr      x8
007373A68  adrp     x26, #0x95a2000
007373A6C  ldrb     w8, [x26, #0x347]
007373A70  cbnz     w8, #0x7373a88
007373A74  adrp     x0, #0x8f59000
007373A78  ldr      x0, [x0, #0x178]
007373A7C  bl       #0x382bd14 ;
007373A80  mov      w8, #1
007373A84  strb     w8, [x26, #0x347]
007373A88  adrp     x29, #0x8f59000
007373A8C  ldr      x29, [x29, #0x178]
007373A90  ldr      x2, [x29]
007373A94  ldrb     w8, [x2, #0x53]
007373A98  tbnz     w8, #5, #0x7373aa8
007373A9C  mov      w8, #0x7a
007373AA0  str      w8, [x22, #0x20]
007373AA4  b        #0x7373ab8 ;
007373AA8  ldr      x8, [x2, #0x60]
007373AAC  mov      w1, #0x7a
007373AB0  mov      x0, x22
007373AB4  blr      x8
007373AB8  cbz      x21, #0x7373c14
007373ABC  ldr      w8, [x21, #0x18]
007373AC0  cbz      w8, #0x7373c18
007373AC4  str      x22, [x21, #0x20]!
007373AC8  mov      x0, x21
007373ACC  mov      x1, x22
007373AD0  bl       #0x382bcb8 ;
007373AD4  ldr      x0, [x27]
007373AD8  ldr      x20, [x20]
007373ADC  bl       #0x382bfa0 ;
007373AE0  mov      x1, xzr
007373AE4  mov      x21, x0
007373AE8  bl       #0x6da02a4 ; Proto.Common.RewardDto$$.ctor
007373AEC  cbz      x21, #0x7373c14
007373AF0  ldrb     w8, [x25, #0x346]
007373AF4  cbnz     w8, #0x7373b0c
007373AF8  adrp     x0, #0x8f59000
007373AFC  ldr      x0, [x0, #0x168]
007373B00  bl       #0x382bd14 ;
007373B04  mov      w8, #1
007373B08  strb     w8, [x25, #0x346]
007373B0C  ldr      x2, [x28]
007373B10  ldrb     w8, [x2, #0x53]
007373B14  tbnz     w8, #5, #0x7373b24
007373B18  mov      w8, #2
007373B1C  str      w8, [x21, #0x1c]
007373B20  b        #0x7373b34 ;
007373B24  ldr      x8, [x2, #0x60]
007373B28  mov      w1, #2
007373B2C  mov      x0, x21
007373B30  blr      x8
007373B34  ldrb     w8, [x26, #0x347]
007373B38  cbnz     w8, #0x7373b50
007373B3C  adrp     x0, #0x8f59000
007373B40  ldr      x0, [x0, #0x178]
007373B44  bl       #0x382bd14 ;
007373B48  mov      w8, #1
007373B4C  strb     w8, [x26, #0x347]
007373B50  ldr      x2, [x29]
007373B54  ldrb     w8, [x2, #0x53]
007373B58  tbnz     w8, #5, #0x7373b68
007373B5C  mov      w8, #0xea
007373B60  str      w8, [x21, #0x20]
007373B64  b        #0x7373b78 ;
007373B68  ldr      x8, [x2, #0x60]
007373B6C  mov      w1, #0xea
007373B70  mov      x0, x21
007373B74  blr      x8
007373B78  cbz      x20, #0x7373c14
007373B7C  ldr      w8, [x20, #0x18]
007373B80  cmp      w8, #1
007373B84  b.ls     #0x7373c18
007373B88  str      x21, [x20, #0x28]!
007373B8C  mov      x0, x20
007373B90  mov      x1, x21
007373B94  bl       #0x382bcb8 ;
007373B98  ldr      x0, [x23]
007373B9C  ldr      w8, [x0, #0xe0]
007373BA0  cbnz     w8, #0x7373ba8
007373BA4  bl       #0x382be8c ;
007373BA8  ldrb     w8, [x24, #0x59d]
007373BAC  cbnz     w8, #0x7373bc4
007373BB0  adrp     x0, #0x8ee1000
007373BB4  ldr      x0, [x0, #0x5e0]
007373BB8  bl       #0x382bd14 ;
007373BBC  mov      w8, #1
007373BC0  strb     w8, [x24, #0x59d]
007373BC4  ldr      x0, [x23]
007373BC8  ldr      w8, [x0, #0xe0]
007373BCC  cbnz     w8, #0x7373bd8
007373BD0  bl       #0x382be8c ;
007373BD4  ldr      x0, [x23]
007373BD8  ldr      x8, [x0, #0xb8]
007373BDC  mov      x2, x19
007373BE0  ldp      x20, x19, [sp, #0x50]
007373BE4  ldp      x22, x21, [sp, #0x40]
007373BE8  ldr      x0, [x8, #0x28]
007373BEC  ldp      x24, x23, [sp, #0x30]
007373BF0  ldp      x26, x25, [sp, #0x20]
007373BF4  ldp      x28, x27, [sp, #0x10]
007373BF8  mov      w1, #0x17
007373BFC  mov      w3, #1
007373C00  mov      x4, xzr
007373C04  mov      x5, xzr
007373C08  mov      x6, xzr
007373C0C  ldp      x29, x30, [sp], #0x60
007373C10  b        #0x7257458 ; HotFix.FrameworkExpand$$OpenView
007373C14  bl       #0x382bfb8 ;
007373C18  bl       #0x382bfc0 ;

; HotFix.BattleResultViewMainModule$$OnAnimationEventListen
; RVA 0x7373C1C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007373C1C  stp      x30, x23, [sp, #-0x30]!
007373C20  stp      x22, x21, [sp, #0x10]
007373C24  stp      x20, x19, [sp, #0x20]
007373C28  adrp     x22, #0x95a7000
007373C2C  adrp     x23, #0x8f92000
007373C30  ldrb     w8, [x22, #0xa46]
007373C34  ldr      x23, [x23, #0xfc0]
007373C38  mov      x20, x2
007373C3C  mov      x21, x1
007373C40  mov      x19, x0
007373C44  tbnz     w8, #0, #0x7373c74
007373C48  adrp     x0, #0x8f92000
007373C4C  ldr      x0, [x0, #0xfc0]
007373C50  bl       #0x382bd14 ;
007373C54  adrp     x0, #0x8f92000
007373C58  ldr      x0, [x0, #0xe50]
007373C5C  bl       #0x382bd14 ;
007373C60  adrp     x0, #0x8f92000
007373C64  ldr      x0, [x0, #0xd80]
007373C68  bl       #0x382bd14 ;
007373C6C  mov      w8, #1
007373C70  strb     w8, [x22, #0xa46]
007373C74  ldr      x3, [x23]
007373C78  ldrb     w8, [x3, #0x53]
007373C7C  tbnz     w8, #5, #0x7373cf4
007373C80  adrp     x8, #0x8f92000
007373C84  ldr      x8, [x8, #0xd80]
007373C88  mov      x0, x20
007373C8C  mov      x2, xzr
007373C90  ldr      x1, [x8]
007373C94  bl       #0x79d1644 ; System.String$$op_Equality
007373C98  tbz      w0, #0, #0x7373d14
007373C9C  ldr      x0, [x19, #0x110]
007373CA0  cbz      x0, #0x7373d24
007373CA4  mov      w1, #1
007373CA8  mov      x2, xzr
007373CAC  bl       #0x8749d30 ; UnityEngine.Behaviour$$set_enabled
007373CB0  adrp     x20, #0x8f92000
007373CB4  ldr      x20, [x20, #0xe50]
007373CB8  ldr      x19, [x19, #0x110]
007373CBC  ldr      x0, [x20]
007373CC0  ldr      w8, [x0, #0xe0]
007373CC4  cbnz     w8, #0x7373ccc
007373CC8  bl       #0x382be8c ;
007373CCC  cbz      x19, #0x7373d24
007373CD0  ldr      x8, [x20]
007373CD4  mov      x0, x19
007373CD8  ldp      x20, x19, [sp, #0x20]
007373CDC  ldp      x22, x21, [sp, #0x10]
007373CE0  ldr      x8, [x8, #0xb8]
007373CE4  mov      x2, xzr
007373CE8  ldr      w1, [x8, #8]
007373CEC  ldp      x30, x23, [sp], #0x30
007373CF0  b        #0x86d3960 ; UnityEngine.Animator$$SetTrigger
007373CF4  ldr      x4, [x3, #0x60]
007373CF8  mov      x0, x19
007373CFC  mov      x1, x21
007373D00  mov      x2, x20
007373D04  ldp      x20, x19, [sp, #0x20]
007373D08  ldp      x22, x21, [sp, #0x10]
007373D0C  ldp      x30, x23, [sp], #0x30
007373D10  br       x4
007373D14  ldp      x20, x19, [sp, #0x20]
007373D18  ldp      x22, x21, [sp, #0x10]
007373D1C  ldp      x30, x23, [sp], #0x30
007373D20  ret
007373D24  bl       #0x382bfb8 ;

; HotFix.BattleResultViewMainModule$$.ctor
; RVA 0x7373D28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007373D28  stp      x30, x21, [sp, #-0x20]!
007373D2C  stp      x20, x19, [sp, #0x10]
007373D30  adrp     x20, #0x95a7000
007373D34  adrp     x21, #0x8f92000
007373D38  ldrb     w8, [x20, #0xa47]
007373D3C  ldr      x21, [x21, #0xfc8]
007373D40  mov      x19, x0
007373D44  tbnz     w8, #0, #0x7373d74
007373D48  adrp     x0, #0x8f92000
007373D4C  ldr      x0, [x0, #0xfc8]
007373D50  bl       #0x382bd14 ;
007373D54  adrp     x0, #0x8f92000
007373D58  ldr      x0, [x0, #0xfd0]
007373D5C  bl       #0x382bd14 ;
007373D60  adrp     x0, #0x8f92000
007373D64  ldr      x0, [x0, #0xfd8]
007373D68  bl       #0x382bd14 ;
007373D6C  mov      w8, #1
007373D70  strb     w8, [x20, #0xa47]
007373D74  ldr      x1, [x21]
007373D78  ldrb     w8, [x1, #0x53]
007373D7C  tbnz     w8, #5, #0x7373dc4
007373D80  adrp     x8, #0x8f92000
007373D84  ldr      x8, [x8, #0xfd8]
007373D88  adrp     x20, #0x8f92000
007373D8C  ldr      x0, [x8]
007373D90  ldr      x20, [x20, #0xfd0]
007373D94  bl       #0x382bfa0 ;
007373D98  ldr      x1, [x20]
007373D9C  mov      x20, x0
007373DA0  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
007373DA4  add      x0, x19, #0x148
007373DA8  mov      x1, x20
007373DAC  str      x20, [x19, #0x148]
007373DB0  bl       #0x382bcb8 ;
007373DB4  mov      x0, x19
007373DB8  ldp      x20, x19, [sp, #0x10]
007373DBC  ldp      x30, x21, [sp], #0x20
007373DC0  b        #0x736b9b0 ; HotFix.BaseResulViewModule$$.ctor
007373DC4  ldr      x2, [x1, #0x60]
007373DC8  mov      x0, x19
007373DCC  ldp      x20, x19, [sp, #0x10]
007373DD0  ldp      x30, x21, [sp], #0x20
007373DD4  br       x2

; HotFix.BattleResultViewMainModule$$.cctor
; RVA 0x7373DD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007373DD8  stp      x30, x23, [sp, #-0x30]!
007373DDC  stp      x22, x21, [sp, #0x10]
007373DE0  stp      x20, x19, [sp, #0x20]
007373DE4  adrp     x22, #0x95a7000
007373DE8  adrp     x23, #0x8f92000
007373DEC  adrp     x19, #0x8f92000
007373DF0  adrp     x21, #0x8f92000
007373DF4  adrp     x20, #0x8f92000
007373DF8  ldrb     w8, [x22, #0xa48]
007373DFC  ldr      x23, [x23, #0xd98]
007373E00  ldr      x19, [x19, #0xe50]
007373E04  ldr      x21, [x21, #0xda0]
007373E08  ldr      x20, [x20, #0xd80]
007373E0C  tbnz     w8, #0, #0x7373e48
007373E10  adrp     x0, #0x8f92000
007373E14  ldr      x0, [x0, #0xe50]
007373E18  bl       #0x382bd14 ;
007373E1C  adrp     x0, #0x8f92000
007373E20  ldr      x0, [x0, #0xd98]
007373E24  bl       #0x382bd14 ;
007373E28  adrp     x0, #0x8f92000
007373E2C  ldr      x0, [x0, #0xda0]
007373E30  bl       #0x382bd14 ;
007373E34  adrp     x0, #0x8f92000
007373E38  ldr      x0, [x0, #0xd80]
007373E3C  bl       #0x382bd14 ;
007373E40  mov      w8, #1
007373E44  strb     w8, [x22, #0xa48]
007373E48  ldr      x0, [x23]
007373E4C  mov      x1, xzr
007373E50  bl       #0x86d2dc4 ; UnityEngine.Animator$$StringToHash
007373E54  ldr      x8, [x19]
007373E58  mov      x1, xzr
007373E5C  ldr      x8, [x8, #0xb8]
007373E60  str      w0, [x8]
007373E64  ldr      x0, [x21]
007373E68  bl       #0x86d2dc4 ; UnityEngine.Animator$$StringToHash
007373E6C  ldr      x8, [x19]
007373E70  mov      x1, xzr
007373E74  ldr      x8, [x8, #0xb8]
007373E78  str      w0, [x8, #4]
007373E7C  ldr      x0, [x20]
007373E80  bl       #0x86d2dc4 ; UnityEngine.Animator$$StringToHash
007373E84  ldr      x8, [x19]
007373E88  ldp      x20, x19, [sp, #0x20]
007373E8C  ldp      x22, x21, [sp, #0x10]
007373E90  ldr      x8, [x8, #0xb8]
007373E94  str      w0, [x8, #8]
007373E98  ldp      x30, x23, [sp], #0x30
007373E9C  ret
