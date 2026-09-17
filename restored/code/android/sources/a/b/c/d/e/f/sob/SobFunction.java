package a.b.c.d.e.f.sob;

import android.util.SparseArray;
import com.bytedance.msdk.adapter.sigmob.SigmobManager;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction;

/* JADX INFO: loaded from: classes.dex */
public class SobFunction extends AdnAdapterBaseFunction {
    @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
    public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
        if (i != 9000) {
            return null;
        }
        return (T) new SigmobManager();
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
    public SparseArray<Object> get() {
        return null;
    }
}
