package com.qq.gdt.action.d;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    public static String a() {
        return a(com.qq.gdt.action.d.a().g(), false);
    }

    /* JADX WARN: Unreachable blocks removed: 5, instructions: 12 */
    /*  JADX ERROR: JadxRuntimeException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxRuntimeException: Can't find top splitter block for handler:B:11:0x0021
        	at jadx.core.utils.BlockUtils.getTopSplitterForHandler(BlockUtils.java:1478)
        	at jadx.core.dex.visitors.regions.maker.ExcHandlersRegionMaker.collectHandlerRegions(ExcHandlersRegionMaker.java:53)
        	at jadx.core.dex.visitors.regions.maker.ExcHandlersRegionMaker.process(ExcHandlersRegionMaker.java:38)
        	at jadx.core.dex.visitors.regions.RegionMakerVisitor.visit(RegionMakerVisitor.java:27)
        */
    public static synchronized java.lang.String a(android.content.Context r2, boolean r3) {
        /*
            java.lang.String r2 = "getSubscriberId outside throwable"
            java.lang.Class<com.qq.gdt.action.d.g> r3 = com.qq.gdt.action.d.g.class
            monitor-enter(r3)
            java.lang.String r2 = ""
            monitor-exit(r3)
            return r2
        L9:
            r0 = move-exception
            java.lang.StringBuilder r1 = new java.lang.StringBuilder     // Catch: java.lang.Throwable -> L21
            r1.<init>(r2)     // Catch: java.lang.Throwable -> L21
            java.lang.StringBuilder r2 = r1.append(r0)     // Catch: java.lang.Throwable -> L21
            java.lang.String r2 = r2.toString()     // Catch: java.lang.Throwable -> L21
            r0 = 0
            java.lang.Object[] r0 = new java.lang.Object[r0]     // Catch: java.lang.Throwable -> L21
            com.qq.gdt.action.i.o.a(r2, r0)     // Catch: java.lang.Throwable -> L21
            java.lang.String r2 = ""
            monitor-exit(r3)
            return r2
        L21:
            r2 = move-exception
            monitor-exit(r3)
            throw r2
        */
        throw new UnsupportedOperationException("Method not decompiled: com.qq.gdt.action.d.g.a(android.content.Context, boolean):java.lang.String");
    }
}
