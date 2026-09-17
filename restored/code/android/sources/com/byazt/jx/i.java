package com.byazt.jx;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 214, 42})
public class i implements ve {
    public final String c;
    public final c tt;
    public final boolean ve;

    public enum c {
        MERGE,
        ADD,
        SUBTRACT,
        INTERSECT,
        EXCLUDE_INTERSECTIONS;

        public static c c(int i) {
            if (i == 1) {
                return MERGE;
            }
            if (i == 2) {
                return ADD;
            }
            if (i == 3) {
                return SUBTRACT;
            }
            if (i == 4) {
                return INTERSECT;
            }
            if (i == 5) {
                return EXCLUDE_INTERSECTIONS;
            }
            return MERGE;
        }
    }

    public i(String str, c cVar, boolean z) {
        this.c = str;
        this.tt = cVar;
        this.ve = z;
    }

    public String c() {
        return this.c;
    }

    public c tt() {
        return this.tt;
    }

    public boolean ve() {
        return this.ve;
    }

    @Override // com.byazt.jx.ve
    public com.byazt.zy.ve c(com.byazt.ga.x xVar, com.byazt.ga.a aVar, com.byazt.zk.ve veVar) {
        return new com.byazt.zy.t(this);
    }

    public String toString() {
        return "MergePaths{mode=" + this.tt + '}';
    }
}
