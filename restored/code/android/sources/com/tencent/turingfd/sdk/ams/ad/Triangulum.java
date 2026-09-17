package com.tencent.turingfd.sdk.ams.ad;

import java.util.Iterator;
import java.util.LinkedList;

/* JADX INFO: loaded from: classes4.dex */
public final class Triangulum implements Iterable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final int f3901a;
    public final LinkedList b = new LinkedList();

    public Triangulum(int i) {
        this.f3901a = i;
    }

    public final void a(Object obj) {
        if (this.b.size() >= this.f3901a) {
            this.b.poll();
        }
        this.b.offer(obj);
    }

    @Override // java.lang.Iterable
    public final Iterator iterator() {
        return this.b.iterator();
    }
}
