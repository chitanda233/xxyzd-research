package com.onevcat.uniwebview;

import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.t, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0678t extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ C0687w f2929a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0678t(C0687w c0687w) {
        super(0);
        this.f2929a = c0687w;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        return this.f2929a.get_webClient$uniwebview_release().g;
    }
}
