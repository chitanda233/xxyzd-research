package com.onevcat.uniwebview;

import kotlin.jvm.internal.Intrinsics;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class E {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f2825a;
    public final JSONObject b;

    public E(String resultStr) {
        Intrinsics.checkNotNullParameter(resultStr, "resultStr");
        this.f2825a = resultStr;
        this.b = new JSONObject(resultStr);
    }
}
