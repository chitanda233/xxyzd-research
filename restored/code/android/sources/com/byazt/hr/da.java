package com.byazt.hr;

import android.text.TextUtils;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 29, 72})
public class da {
    public static final String c = "TTMediationSDK_da";
    public Map<String, i> tt;
    public com.byazt.jd.ve<i> ve;

    private da() {
        this.ve = new com.byazt.jd.uj(com.byazt.bp.tt.getContext());
        this.tt = new ConcurrentHashMap();
    }

    public static da c() {
        return c.c;
    }

    @com.byazt.zqa.c(c = {0, 1, 29, 45})
    private static class c {
        public static da c = new da();
    }

    public void c(String str, long j) {
        if (this.ve != null) {
            Map<String, i> map = this.tt;
            i iVar = map != null ? map.get(str) : null;
            if (iVar != null) {
                iVar.c(j);
            }
            this.ve.c(str, j);
        }
    }

    public void c(String str, String str2, long j) {
        if (this.ve != null) {
            Map<String, i> map = this.tt;
            i iVar = map != null ? map.get(str + "_" + str2) : null;
            if (iVar != null) {
                iVar.c(j);
            }
            this.ve.c(str, str2, j);
        }
    }

    public void c(String str) {
        if (this.ve != null) {
            Map<String, i> map = this.tt;
            if (map != null) {
                map.remove(str);
            }
            this.ve.delete(str);
        }
    }

    public void c(String str, String str2) {
        if (this.ve != null) {
            Map<String, i> map = this.tt;
            if (map != null) {
                map.remove(str + "_" + str2);
            }
            this.ve.delete(str, str2);
        }
    }

    public void c(i iVar) {
        if (this.ve == null || TextUtils.isEmpty(iVar.da())) {
            return;
        }
        Map<String, i> map = this.tt;
        if (map != null) {
            map.put(iVar.uj(), iVar);
        }
        this.ve.tt(iVar);
    }

    public i tt(String str) {
        if (this.ve == null) {
            return null;
        }
        Map<String, i> map = this.tt;
        i iVar = map != null ? map.get(str) : null;
        if (iVar != null) {
            return iVar;
        }
        i iVarQuery = this.ve.query(str);
        if (iVarQuery != null) {
            this.tt.put(iVarQuery.tt(), iVarQuery);
        }
        return iVarQuery;
    }

    public i tt(String str, String str2) {
        if (this.ve == null) {
            return null;
        }
        Map<String, i> map = this.tt;
        i iVar = map != null ? map.get(str + "_" + str2) : null;
        if (iVar != null) {
            return iVar;
        }
        i iVarQuery = this.ve.query(str, str2);
        if (iVarQuery != null) {
            this.tt.put(iVarQuery.uj(), iVarQuery);
        }
        return iVarQuery;
    }
}
