package com.byazt.fqg;

import com.byazt.omf.p;
import com.byazt.ut.da;
import com.byazt.ut.uj;
import com.bykv.vk.openvk.api.proto.PluginValueSet;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 2056, 20})
public class c {
    public c(PluginValueSet pluginValueSet) {
        if (p.ve) {
            uj.getInstance().setListener(da.c);
        }
    }

    public Map<String, Object> c() {
        if (p.uj >= 7500) {
            return null;
        }
        return da.c.c();
    }
}
