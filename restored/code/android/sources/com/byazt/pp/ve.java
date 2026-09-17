package com.byazt.pp;

import android.text.TextUtils;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1434, 54})
public class ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f1332a;
    public int c;
    public String da;
    public String i;
    public String m;
    public String n;
    public String nu;
    public final Map<String, String> rh = new HashMap();
    public String sl;
    public int sp;
    public String t;
    public String tt;
    public String u;
    public String uj;
    public String ve;
    public String x;
    public String yp;
    public String z;

    public void c(Map<String, String> map) {
        if (map == null || map.isEmpty()) {
            return;
        }
        this.rh.clear();
        this.rh.putAll(map);
    }

    public Map<String, String> c() {
        return this.rh;
    }

    public String tt() {
        return this.da;
    }

    public void c(String str) {
        this.da = str;
    }

    public String ve() {
        return this.sl;
    }

    public void tt(String str) {
        this.sl = str;
    }

    public String uj() {
        return this.t;
    }

    public void ve(String str) {
        this.t = str;
    }

    public String n() {
        return this.u;
    }

    public void uj(String str) {
        this.u = str;
    }

    public String a() {
        return this.yp;
    }

    public void n(String str) {
        this.yp = str;
    }

    public String sp() {
        return this.z;
    }

    public void a(String str) {
        this.z = str;
    }

    public String x() {
        return this.m;
    }

    public void sp(String str) {
        this.m = str;
    }

    public String i() {
        return this.tt;
    }

    public void x(String str) {
        this.tt = str;
    }

    public String da() {
        return this.ve;
    }

    public void i(String str) {
        this.ve = str;
    }

    public void c(int i) {
        this.c = i;
    }

    public String sl() {
        return this.uj;
    }

    public void da(String str) {
        this.uj = str;
    }

    public String t() {
        return TextUtils.isEmpty(this.ve) ? this.tt : this.ve;
    }

    public String u() {
        return this.f1332a;
    }

    public void sl(String str) {
        this.f1332a = str;
    }

    public void t(String str) {
        this.nu = str;
    }

    public String yp() {
        return this.nu;
    }

    public String z() {
        return this.n;
    }

    public void u(String str) {
        this.n = str;
    }

    public int m() {
        return this.sp;
    }

    public void tt(int i) {
        this.sp = i;
    }

    public String nu() {
        return this.x;
    }

    public void yp(String str) {
        this.x = str;
    }

    public String rh() {
        return this.i;
    }

    public void z(String str) {
        this.i = str;
    }

    public String toString() {
        return "{mSdkNum='" + this.c + "', mSlotId='" + this.uj + "', mLevelTag='" + this.n + "', mEcpm=" + this.f1332a + ", mReqBiddingType=" + this.sp + "', mRequestId=" + this.i + ", mSubRitType=" + this.sl + '}';
    }
}
