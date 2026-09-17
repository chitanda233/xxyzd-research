package com.byazt.hr;

import android.text.TextUtils;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 29, 42})
public class i extends uj {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f1003a;
    public String sp;
    public long x;

    public i(String str, String str2, String str3, String str4, int i, String str5, String str6) {
        super(str, str2, str3, str4, i);
        this.x = 0L;
        this.f1003a = 0L;
        try {
            this.f1003a = Long.parseLong(str5);
        } catch (Exception unused) {
        }
        this.sp = str6;
    }

    public i(String str, String str2, String str3, String str4, int i, String str5, String str6, String str7) {
        this(str, str2, str3, str4, i, str5, str6);
        this.x = 0L;
        try {
            this.x = Long.parseLong(str7);
        } catch (Exception unused) {
        }
    }

    public void c(long j) {
        this.x = j;
    }

    public long i() {
        return this.f1003a;
    }

    public String da() {
        return this.sp;
    }

    public long sl() {
        return this.x;
    }

    public boolean t() {
        return this.x != 0;
    }

    @Override // com.byazt.hr.uj
    public boolean x() {
        return (TextUtils.isEmpty(this.sp) || this.f1003a == 0) ? false : true;
    }

    @Override // com.byazt.hr.uj
    public String toString() {
        return "BaseIntervalBean{waterfallId='" + this.c + "', showRulesVersion='" + this.ve + "', timingMode=" + this.n + "}IntervalPacingBean{pacing=" + this.f1003a + ", pacingRuleId='" + this.sp + "', effectiveTime=" + this.x + '}';
    }
}
