package com.kwad.components.core.webview.tachikoma.e;

import com.kwad.components.core.webview.tachikoma.f.f;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final Set<Integer> avb = new HashSet();
    private final ConcurrentHashMap<Integer, Set<f>> avc = new ConcurrentHashMap<>();

    static class a {
        private static final b avd = new b();
    }

    public static b zQ() {
        return a.avd;
    }

    public final boolean cc(int i) {
        if (this.avb.contains(Integer.valueOf(i))) {
            return false;
        }
        this.avb.add(Integer.valueOf(i));
        return true;
    }

    public final void a(int i, f fVar) {
        Set<f> set = this.avc.get(Integer.valueOf(i));
        if (set != null) {
            set.add(fVar);
            return;
        }
        HashSet hashSet = new HashSet();
        hashSet.add(fVar);
        this.avc.put(Integer.valueOf(i), hashSet);
    }

    private void a(int i, String str, String str2) {
        Set<f> set;
        this.avb.remove(Integer.valueOf(i));
        if (this.avc.isEmpty() || this.avc.get(Integer.valueOf(i)) == null || (set = this.avc.get(Integer.valueOf(i))) == null || set.isEmpty()) {
            return;
        }
        this.avc.remove(Integer.valueOf(i));
        Iterator<f> it = set.iterator();
        while (it.hasNext()) {
            it.next().zA();
        }
    }

    private void cd(int i) {
        Set<f> set;
        this.avb.remove(Integer.valueOf(i));
        if (this.avc.isEmpty() || this.avc.get(Integer.valueOf(i)) == null || (set = this.avc.get(Integer.valueOf(i))) == null || set.isEmpty()) {
            return;
        }
        Iterator<f> it = set.iterator();
        while (it.hasNext()) {
            it.next().zB();
        }
        this.avc.remove(Integer.valueOf(i));
    }

    public final void b(int i, String str, String str2) {
        a(i, str, str2);
    }

    public final void ce(int i) {
        cd(i);
    }
}
