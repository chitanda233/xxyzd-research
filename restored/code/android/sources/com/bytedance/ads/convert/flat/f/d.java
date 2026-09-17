package com.bytedance.ads.convert.flat.f;

import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes2.dex */
public final class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static boolean f1698a;
    public static final d b = new d();

    public final synchronized void a() {
        if (f1698a) {
            return;
        }
        f1698a = true;
        Intrinsics.checkNotNullParameter("launch_app", "label");
        Intrinsics.checkNotNullParameter("2", "eventVersion");
        b bVar = new b("launch_app");
        bVar.g = "2";
        bVar.h = null;
        bVar.a("Convert:EventReporterV2");
    }
}
