package com.kwad.sdk.core;

import android.util.Pair;
import android.view.MotionEvent;
import com.kwad.sdk.service.ServiceProvider;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Queue;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static final b aKX = new b(100);
    private static final a aKY = new a(10, 0);
    private static List<c> aKZ = new ArrayList(50);
    private static final List<List<c>> aLa = new ArrayList();
    private static final List<Map<String, Double>> aLb = new ArrayList();
    private static c aLc;

    public static void j(MotionEvent motionEvent) {
        int action = motionEvent.getAction();
        if (action != 0) {
            if (action != 1) {
                if (action != 2) {
                    if (action != 3 && action != 4) {
                        return;
                    }
                }
            }
            a(motionEvent, true);
            return;
        }
        a(motionEvent, false);
    }

    private static void a(MotionEvent motionEvent, boolean z) {
        c cVar = new c(motionEvent);
        c cVar2 = aLc;
        if (cVar2 == null || !cVar2.a(cVar)) {
            aKZ.add(cVar);
            aLc = cVar;
            if (z) {
                if (aKZ.size() > 3 && aKZ.size() < 100) {
                    aLa.add(aKZ);
                }
                aKZ = new ArrayList(50);
                aLc = null;
            }
        }
    }

    public static Pair<List<String>, Double> IV() {
        Iterator<List<c>> it = aLa.iterator();
        double d = 0.0d;
        while (it.hasNext()) {
            Iterator<c> it2 = it.next().iterator();
            while (it2.hasNext()) {
                aKX.n(it2.next());
            }
            List<Map<String, Double>> list = aLb;
            double dE = E(list);
            if (dE > d) {
                d = dE;
            }
            list.clear();
            a aVar = aKY;
            b bVar = aKX;
            aVar.n(bVar.toString());
            bVar.clear();
        }
        return new Pair<>(IW(), Double.valueOf(d));
    }

    private static List<String> IW() {
        List<String> listJa = aKY.Ja();
        IY();
        IX();
        return listJa;
    }

    private static void IX() {
        aLb.clear();
        aLa.clear();
        aKZ.clear();
    }

    private static double E(List<Map<String, Double>> list) {
        double d = 0.0d;
        try {
            ArrayList arrayList = new ArrayList(list.size());
            ArrayList arrayList2 = new ArrayList(list.size());
            ArrayList arrayList3 = new ArrayList(list.size());
            ArrayList arrayList4 = new ArrayList(list.size());
            a(list, arrayList, arrayList2, arrayList3, arrayList4);
            int i = 1;
            for (int i2 = 1; i < list.size() - i2; i2 = 1) {
                int i3 = i;
                double dAbs = Math.abs((((Double) arrayList.get(i)).doubleValue() * ((Double) arrayList4.get(i)).doubleValue()) - (((Double) arrayList2.get(i)).doubleValue() * ((Double) arrayList3.get(i)).doubleValue())) / Math.pow(Math.pow(((Double) arrayList.get(i)).doubleValue(), 2.0d) + Math.pow(((Double) arrayList2.get(i)).doubleValue(), 2.0d), 1.5d);
                if (dAbs > d) {
                    d = dAbs;
                }
                i = i3 + 1;
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return d;
    }

    private static void a(List<Map<String, Double>> list, List<Double> list2, List<Double> list3, List<Double> list4, List<Double> list5) {
        int size = list.size();
        for (int i = 0; i < size; i++) {
            list2.add(Double.valueOf(0.0d));
            list3.add(Double.valueOf(0.0d));
            list4.add(Double.valueOf(0.0d));
            list5.add(Double.valueOf(0.0d));
        }
        int i2 = 1;
        while (i2 < size - 1) {
            int i3 = i2 + 1;
            double dDoubleValue = list.get(i3).get("x").doubleValue();
            int i4 = i2 - 1;
            double dDoubleValue2 = list.get(i4).get("x").doubleValue();
            double dDoubleValue3 = list.get(i3).get("y").doubleValue();
            double dDoubleValue4 = list.get(i4).get("y").doubleValue();
            double dDoubleValue5 = list.get(i2).get("x").doubleValue();
            double dDoubleValue6 = list.get(i2).get("y").doubleValue();
            list2.set(i2, Double.valueOf((dDoubleValue - dDoubleValue2) / 2.0d));
            list3.set(i2, Double.valueOf((dDoubleValue3 - dDoubleValue4) / 2.0d));
            list4.set(i2, Double.valueOf((dDoubleValue - (dDoubleValue5 * 2.0d)) + dDoubleValue2));
            list5.set(i2, Double.valueOf((dDoubleValue3 - (dDoubleValue6 * 2.0d)) + dDoubleValue4));
            i2 = i3;
        }
    }

    private static void IY() {
        aKY.clear();
        aKX.clear();
    }

    public static class c {
        private int action;
        private double x;
        private double y;

        public c(MotionEvent motionEvent) {
            this.x = motionEvent.getX();
            this.y = motionEvent.getY();
            this.action = motionEvent.getAction();
        }

        public final double Jb() {
            return this.x;
        }

        public final double Jc() {
            return this.y;
        }

        private int getAction() {
            return this.action;
        }

        public final boolean a(c cVar) {
            return this.x == cVar.Jb() && this.y == cVar.Jc() && this.action == cVar.getAction();
        }
    }

    public static class b {
        public final int aLd;
        public final Queue<String> aLe = new LinkedList();

        public char IZ() {
            return '|';
        }

        public b(int i) {
            this.aLd = i;
        }

        public boolean n(Object obj) {
            if (!(obj instanceof c)) {
                return false;
            }
            if (this.aLe.size() >= this.aLd) {
                this.aLe.poll();
            }
            HashMap map = new HashMap();
            c cVar = (c) obj;
            double dJb = cVar.Jb();
            double dJc = cVar.Jc();
            map.put("x", Double.valueOf(dJb));
            map.put("y", Double.valueOf(dJc));
            e.aLb.add(map);
            return this.aLe.offer(dJb + "_" + dJc);
        }

        public final void clear() {
            this.aLe.clear();
        }

        public String toString() {
            StringBuilder sb = new StringBuilder();
            Iterator<String> it = this.aLe.iterator();
            while (it.hasNext()) {
                sb.append(it.next()).append(IZ());
            }
            if (sb.length() > 0) {
                sb.deleteCharAt(sb.length() - 1);
            }
            return sb.toString();
        }
    }

    public static class a extends b {
        @Override // com.kwad.sdk.core.e.b
        public final char IZ() {
            return ',';
        }

        /* synthetic */ a(int i, byte b) {
            this(10);
        }

        private a(int i) {
            super(i);
        }

        @Override // com.kwad.sdk.core.e.b
        public final boolean n(Object obj) {
            if (!(obj instanceof String)) {
                return false;
            }
            if (this.aLe.size() >= this.aLd) {
                this.aLe.poll();
            }
            return this.aLe.offer((String) obj);
        }

        public final List<String> Ja() {
            return new ArrayList(this.aLe);
        }
    }
}
