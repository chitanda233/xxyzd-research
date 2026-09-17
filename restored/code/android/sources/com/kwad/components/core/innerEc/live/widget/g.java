package com.kwad.components.core.innerEc.live.widget;

import android.content.Context;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public abstract class g {

    public static final class b extends g {
        public final String toString() {
            return "ImmediatelySpeed";
        }
    }

    public static final class c extends g {
        public static final c Zh = new c();

        public final String toString() {
            return "NormalSpeed";
        }
    }

    public static final class e extends g {
        public final String toString() {
            return "SlowSpeed";
        }
    }

    public static final class f extends g {
        private final int Zl;

        public final int ti() {
            return this.Zl;
        }

        public final String toString() {
            return "SpecificSpeed(speedPx=" + this.Zl + ")";
        }
    }

    public static final class a extends g {
        private final int rg;

        public final int tg() {
            return this.rg;
        }

        public final String toString() {
            return "FixedTimeSpeed(time=" + this.rg + ")";
        }
    }

    public static final class d extends g {
        private final List<l> Zi;
        private volatile List<k> Zj;
        private volatile boolean Zk;
        private final Context context;

        public final List<k> th() {
            if (!this.Zk) {
                synchronized (this) {
                    if (!this.Zk) {
                        try {
                            this.Zj = o(this.Zi);
                        } catch (Exception e) {
                            com.kwad.sdk.core.d.c.i("LiveCommentScrollSpeedStrategy", "covertSegmentsToPercentDataList error" + e);
                            this.Zj = null;
                        }
                        this.Zk = true;
                    }
                }
            }
            return this.Zj;
        }

        public final String toString() {
            return "SegmentsSpeed(segments=" + this.Zi + ")";
        }

        private List<k> o(List<l> list) {
            ArrayList arrayList = new ArrayList();
            Iterator<l> it = list.iterator();
            int i = 0;
            while (it.hasNext()) {
                i += it.next().aal;
            }
            ArrayList arrayList2 = new ArrayList();
            for (l lVar : list) {
                float f = (lVar.aal * 1.0f) / i;
                arrayList.add(Integer.valueOf((int) (((f * 1000.0f) * 1000.0f) / com.kwad.sdk.c.a.a.a(this.context, lVar.aam))));
                k kVar = new k();
                kVar.aak = f;
                arrayList2.add(kVar);
            }
            Iterator it2 = arrayList.iterator();
            int iIntValue = 0;
            while (it2.hasNext()) {
                iIntValue += ((Integer) it2.next()).intValue();
            }
            for (int i2 = 0; i2 < arrayList2.size(); i2++) {
                ((k) arrayList2.get(i2)).aaj = (((Integer) arrayList.get(i2)).intValue() * 1.0f) / iIntValue;
            }
            com.kwad.sdk.core.d.c.i("LiveCommentScrollSpeedStrategy", "covertSegmentsToPercentDataListsegments " + list + "percentDataList" + arrayList2);
            return arrayList2;
        }

        public final int aY(int i) {
            try {
                Iterator<l> it = this.Zi.iterator();
                int i2 = 0;
                while (it.hasNext()) {
                    i2 += it.next().aal;
                }
                if (i2 <= 0) {
                    return 0;
                }
                int iA = 0;
                for (l lVar : this.Zi) {
                    iA += (int) (((i * ((lVar.aal * 1.0f) / i2)) * 1000.0f) / com.kwad.sdk.c.a.a.a(this.context, lVar.aam));
                }
                return iA;
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.i("LiveCommentScrollSpeedStrategy", "SegmentsSpeed calculateScrollTime error" + e);
                return 0;
            }
        }
    }

    public static boolean n(List<k> list) {
        if (list == null || list.isEmpty()) {
            return false;
        }
        for (k kVar : list) {
            if (kVar.aak <= 0.0f || kVar.aaj <= 0.0f) {
                return false;
            }
        }
        return true;
    }
}
