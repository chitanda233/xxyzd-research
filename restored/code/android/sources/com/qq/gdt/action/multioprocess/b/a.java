package com.qq.gdt.action.multioprocess.b;

import java.io.Serializable;

/* JADX INFO: loaded from: classes3.dex */
public class a implements Serializable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    b.a f3097a;
    b.i b;
    b.g c;
    b.h d;
    b.f e;
    b.d f;
    b.e g;
    b.m h;
    b.k i;
    b.l j;
    b.c k;
    b.C0552b l;
    b.j m;

    public b.a a() {
        return this.f3097a;
    }

    public void a(b.a aVar) {
        this.f3097a = aVar;
    }

    public void a(b.C0552b c0552b) {
        this.l = c0552b;
    }

    public void a(b.c cVar) {
        this.k = cVar;
    }

    public void a(b.d dVar) {
        this.f = dVar;
    }

    public void a(b.e eVar) {
        this.g = eVar;
    }

    public void a(b.f fVar) {
        this.e = fVar;
    }

    public void a(b.g gVar) {
        this.c = gVar;
    }

    public void a(b.h hVar) {
        this.d = hVar;
    }

    public void a(b.i iVar) {
        this.b = iVar;
    }

    public void a(b.j jVar) {
        this.m = jVar;
    }

    public void a(b.k kVar) {
        this.i = kVar;
    }

    public void a(b.l lVar) {
        this.j = lVar;
    }

    public void a(b.m mVar) {
        this.h = mVar;
    }

    public b.i b() {
        return this.b;
    }

    public b.g c() {
        return this.c;
    }

    public b.h d() {
        return this.d;
    }

    public b.f e() {
        return this.e;
    }

    public b.d f() {
        return this.f;
    }

    public b.e g() {
        return this.g;
    }

    public b.m h() {
        return this.h;
    }

    public b.k i() {
        return this.i;
    }

    public b.l j() {
        return this.j;
    }

    public b.c k() {
        return this.k;
    }

    public b.C0552b l() {
        return this.l;
    }

    public b.j m() {
        return this.m;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder("{\"androidIdItem\":");
        sb.append(this.f3097a);
        sb.append(",\"imeiItem\":").append(this.b);
        sb.append(",\"imei0Item\":").append(this.c);
        sb.append(",\"imei1Item\":").append(this.d);
        sb.append(",\"deviceIdItem\":").append(this.e);
        sb.append(",\"deviceId0Item\":").append(this.f);
        sb.append(",\"deviceId1Item\":").append(this.g);
        sb.append(",\"meidItem\":").append(this.h);
        sb.append(",\"meid0Item\":").append(this.i);
        sb.append(",\"meid1Item\":").append(this.j);
        sb.append(",\"buildModelItem\":").append(this.k);
        sb.append(",\"bssidItem\":").append(this.l);
        sb.append(",\"imsiItem\":").append(this.m);
        sb.append('}');
        return sb.toString();
    }
}
