package com.byazt.lw;

import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 2104, 42})
public class i extends nu {
    public i() {
        super(com.byazt.zg.ve.LT);
    }

    @Override // com.byazt.dr.c
    public Object c(Map<String, JSONObject> map) {
        Object objC;
        Object objC2 = this.c.c(map);
        if (objC2 == null || (objC = this.tt.c(map)) == null) {
            return null;
        }
        return com.byazt.kq.uj.c(objC2, (Number) objC);
    }
}
