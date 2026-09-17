package com.tencent.turingfd.sdk.ams.ad;

import java.text.DecimalFormat;
import java.text.DecimalFormatSymbols;
import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public final class Tangor extends ThreadLocal {
    @Override // java.lang.ThreadLocal
    public final Object initialValue() {
        return new DecimalFormat("#.##", new DecimalFormatSymbols(Locale.US));
    }
}
