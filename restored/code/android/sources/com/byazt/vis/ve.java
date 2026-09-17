package com.byazt.vis;

import android.content.Context;
import com.byazt.ddx.uj;
import com.byazt.ete.ic;
import com.byazt.omf.EmptyView;
import com.byazt.omf.gt;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1810, 54})
public class ve extends tt {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f1510a;
    public EmptyView i;
    public c n;
    public Map<String, Object> sp;
    public Double x;

    public interface c {
        boolean c();
    }

    public void c(c cVar) {
        this.n = cVar;
    }

    public void c(String str) {
        this.f1510a = str;
    }

    public void c(EmptyView emptyView) {
        this.i = emptyView;
    }

    public void c(Map<String, Object> map) {
        Map<String, Object> map2 = this.sp;
        if (map2 == null) {
            this.sp = map;
        } else {
            map2.putAll(map);
        }
    }

    public void c(Double d) {
        this.x = d;
    }

    public ve() {
    }

    public ve(ic icVar, Context context) {
        this.c = icVar;
        this.tt = context;
        this.sp = new HashMap();
    }

    @Override // com.byazt.vis.tt, com.byazt.zo.c
    public int c(Map<String, Object> map, com.byazt.zo.ve veVar) {
        c cVar;
        if (!gt.tt().xx() || (cVar = this.n) == null || cVar.c()) {
            return 0;
        }
        EmptyView emptyView = this.i;
        if (emptyView == null) {
            this.sp.put("show_send_type", 1);
            uj.c(this.c, this.f1510a, this.sp, this.x);
        } else {
            emptyView.c("checkWhenClicked");
        }
        return 0;
    }
}
